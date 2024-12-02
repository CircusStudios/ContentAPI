namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
    using ContentAPI.API.Features;
    using HarmonyLib;

    using PlayerAPI = global::Player;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PlayerAPI), "OnDestroy")]
    internal class RemovePlayerPatch
    {
        private static void Postfix(PlayerAPI __instance)
        {
            Player.DestroyPlayer(__instance);
        }
    }
}