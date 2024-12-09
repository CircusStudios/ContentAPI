namespace ContentAPI.Patches.Events.Player
{
    using ContentAPI.Events.EventArgs.Player;
    using ContentAPI.Events.Handlers;

    using PlayerAPI = global::Player;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    /// <summary>
    /// Patch for when a player plays a sound.
    /// </summary>
    [HarmonyPatch(typeof(DivingBellSuitCellUI), nameof(DivingBellSuitCellUI.Set))]
    internal class DivingBellTextEvent
    {
        private static void Postfix(DivingBellSuitCellUI __instance, PlayerAPI player, float dst)
        {
            DivingBellTextEventArgs args = new(API.Features.Player.Get(player), __instance.m_nameText, __instance.m_oxygenText, __instance.m_distanceText, dst);
            PlayerEventHandler.DivingBellText.Invoke(args);
        }
    }
}