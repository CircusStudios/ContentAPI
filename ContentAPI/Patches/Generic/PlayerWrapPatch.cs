namespace ContentAPI.Patches.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using ContentAPI.API.Features;
    using ContentAPI.Events.Handlers;
    using HarmonyLib;
    using PlayerAPI = global::Player;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PlayerAPI), nameof(PlayerAPI.DoInits))]
    internal class PlayerWrapPatch
    {
        private static void Postfix(PlayerAPI __instance)
        {
            Player playerAPI = new(__instance);
            PlayerEventHandler.PlayerCreated.Invoke(new(playerAPI));
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
            PlayerEventHandler.PlayerDestroyed.Invoke(new(Player.Get(__instance)));
            Player.DestroyPlayer(__instance);
        }
    }
}