namespace ContentAPI.Events.EventArgs.Monsters
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.API.Interface.Events;

    /// <summary>
    /// Event args for bot being created.
    /// </summary>
    public class MonsterCreatingEventArgs : IDeniableEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterCreatingEventArgs"/> class.
        /// </summary>
        /// <param name="bot">The Bot created.</param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed" /></param>
        public MonsterCreatingEventArgs(Bot bot, bool isAllowed = true)
        {
            Bot = bot;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the Bot created.
        /// </summary>
        public Bot Bot { get; }

        /// <inheritdoc cref="IsAllowed" />
        public bool IsAllowed { get; set; }
    }
}