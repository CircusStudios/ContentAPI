namespace ContentAPI.Patches.Events.Content
{
    using ContentAPI.Events.EventArgs.Content;
    using ContentAPI.Events.Handlers;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    /// <summary>
    /// Patch for destroying Bots.
    /// </summary>
    [HarmonyPatch(typeof(ContentBuffer), nameof(ContentBuffer.GetScore))]
    internal class PublishingContentEvent
    {
        private static void Postfix(ref float __result)
        {
            ContentScoreEventArgs ev = new ContentScoreEventArgs(__result);
            ContentEventHandler.PublishingContent.Invoke(ev);

            __result = ev.Score;
        }
    }
}