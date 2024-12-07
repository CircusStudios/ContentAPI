namespace ContentAPI.Patches.Events.Bots
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.Events.Handlers;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    using BotAPI = global::Bot;

    /// <summary>
    /// Patch for destroying Bots.
    /// </summary>
    [HarmonyPatch(typeof(BotAPI), nameof(BotAPI.OnDestroy))]
    internal class DestroyingEvent
    {
        private static void Prefix(BotAPI __instance)
        {
            BotEventHandler.MonsterDestroying.Invoke(new(Bot.Get(__instance)));
        }
    }
}