namespace ContentAPI.Patches.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using System.Collections.Generic;
    using System.Reflection.Emit;
    using ContentAPI.API.Features;
    using ContentAPI.API.Features.Pools;
    using ContentAPI.Events.Handlers;
    using HarmonyLib;
    using static HarmonyLib.AccessTools;
    using PlayerAPI = global::Player;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PlayerAPI), nameof(PlayerAPI.Start), MethodType.Enumerator)]
    internal class PlayerWrapPatch
    {
        /// <summary>
        /// Event caller.
        /// </summary>
        /// <param name="player">Player that is getting.</param>
        public static void CallEvent(Player player) => PlayerEventHandler.PlayerCreated.Invoke(new(player));

        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            /*Player playerAPI = new(__instance);
            PlayerEventHandler.PlayerCreated.Invoke(new(playerAPI));*/

            List<CodeInstruction> newInstructions = ListPool<CodeInstruction>.Pool.Rent(instructions);

            LocalBuilder player = generator.DeclareLocal(typeof(Player));

            int offset = 2;
            int index = newInstructions.FindIndex(
                instruction => instruction.Calls(Method(typeof(PlayerAPI), nameof(PlayerAPI.LoadHat)))) + offset;

            newInstructions.InsertRange(
                index,
                new CodeInstruction[]
                {
                    // new(this);
                    new CodeInstruction(OpCodes.Ldarg_0),
                    new(OpCodes.Newobj, GetDeclaredConstructors(typeof(Player))[0]),
                    new(OpCodes.Call, Method(typeof(PlayerWrapPatch), nameof(CallEvent))),
                });

            for (int z = 0; z < newInstructions.Count; z++)
                yield return newInstructions[z];

            ListPool<CodeInstruction>.Pool.Return(newInstructions);
        }
    }

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PlayerAPI), "OnDestroy")]
    internal class RemovePlayerPatch
    {
        private static void Prefix(PlayerAPI __instance)
        {
            PlayerEventHandler.PlayerDestroying.Invoke(new(Player.Get(__instance)));
            Player.DestroyPlayer(__instance);
        }
    }
}