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
    internal class BotLoosingTargetEvent
    {
        private static bool Prefix(BotAPI __instance)
        {
            if (__instance.targetPlayer == null)
                return true;

            MonsterLosePlayerEventArgs args = new(Bot.Get(__instance), API.Features.Player.Get(__instance.targetPlayer));
            BotEventHandler.LoosingPlayer.Invoke(args);

            if (!args.IsAllowed)
                return false;

            return true;
        }
    }
}