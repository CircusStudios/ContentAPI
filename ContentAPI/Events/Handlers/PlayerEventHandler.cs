namespace ContentAPI.Events.Handlers
{
    using ContentAPI.Events.EventArgs.Player;
    using UnityEngine.Events;

    /// <summary>
    /// Handler for player events.
    /// </summary>
    public static class PlayerEventHandler
    {
        /// <summary>
        /// Gets the event for player being created.
        /// </summary>
        public static UnityEvent<PlayerCreatedEventArgs> PlayerCreated { get; } = new();

        /// <summary>
        /// Gets the event for player being destroyed.
        /// </summary>
        public static UnityEvent<PlayerDestroyingEventArgs> PlayerDestroying { get; } = new();
    }
}