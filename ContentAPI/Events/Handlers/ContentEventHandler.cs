namespace ContentAPI.Events.Handlers
{
    using ContentAPI.Events.EventArgs.Content;
    using UnityEngine.Events;

    /// <summary>
    /// Handler for content event.
    /// </summary>
    public static class ContentEventHandler
    {
        /// <summary>
        /// Gets the event for when the player publish the content.
        /// </summary>
        public static UnityEvent<ContentScoreEventArgs> PublishingContent { get; } = new();

        /// <summary>
        /// Gets the event for when the player publish the content.
        /// </summary>
        public static UnityEvent<GenerateCommentEventArgs> GenerateComments { get; } = new();
    }
}