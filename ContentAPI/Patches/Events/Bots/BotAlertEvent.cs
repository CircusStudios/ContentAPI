namespace ContentAPI.Patches.Events.Bots
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.Events.EventArgs.Monsters;
    using ContentAPI.Events.Handlers;
    using UnityEngine;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    using BotAPI = global::Bot;

    /// <summary>
    /// Patch for destroying Bots.
    /// </summary>
    [HarmonyPatch(typeof(BotAPI), nameof(BotAPI.Alert))]
    internal class BotAlertEvent
    {
        private static bool Prefix(BotAPI __instance, ref Vector3 alertPosition, ref int alerts)
        {
            MonsterAlertEventArgs args = new(Bot.Get(__instance), alertPosition, alerts, true);
            BotEventHandler.MonsterAlerting.Invoke(args);

            if (!args.IsAllowed)
                return false;

            alertPosition = args.Position;
            alerts = args.Alerts;
            return true;
        }
    }
}