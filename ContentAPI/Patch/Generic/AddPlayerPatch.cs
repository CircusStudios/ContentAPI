namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
    using ContentAPI.API.Features;
    using HarmonyLib;

    using PlayerAPI = global::Player;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PlayerAPI), "Awake")]
    internal class AddPlayerPatch
    {
        private static void Postfix(PlayerAPI __instance)
        {
            ContentPlugin.Log.LogDebug("Adding player");
            Player.Dictionary.Add(__instance.gameObject, new Player(__instance));
        }
    }
}