namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
    using ContentAPI.API.Features;
    using ContentAPI.API.Networking;
    using HarmonyLib;

    using PlayerAPI = global::Player;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(SteamLobbyHandler), nameof(SteamLobbyHandler.LeaveLobby))]
    internal class LeaveLobbyPatch
    {
        private static void Postfix(PlayerAPI __instance)
        {
             NetworkManager.OnLobbyLeft();
        }
    }
}