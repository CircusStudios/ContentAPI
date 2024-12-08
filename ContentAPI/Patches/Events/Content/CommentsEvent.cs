namespace ContentAPI.Patches.Events.Content
{
    using System.Collections.Generic;
    using ContentAPI.Events.EventArgs.Content;
    using ContentAPI.Events.Handlers;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    /// <summary>
    /// Patch for destroying Bots.
    /// </summary>
    [HarmonyPatch(typeof(ContentBuffer), nameof(ContentBuffer.GenerateComments))]
    internal class CommentsEvent
    {
        private static void Postfix(ref List<Comment> __result)
        {
            GenerateCommentEventArgs ev = new GenerateCommentEventArgs(__result);
            ContentEventHandler.GenerateComments.Invoke(ev);

            __result = ev.Comments;
        }
    }
}