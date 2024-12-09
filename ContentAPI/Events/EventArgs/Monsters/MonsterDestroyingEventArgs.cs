namespace ContentAPI.Events.EventArgs.Monsters
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.API.Interface.Events;

    /// <summary>
    /// Event args for bot being destroyed.
    /// </summary>
    public class MonsterDestroyingEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterDestroyingEventArgs"/> class.
        /// </summary>
        /// <param name="bot">The Bot destroyed.</param>
        public MonsterDestroyingEventArgs(Bot bot)
        {
            Bot = bot;
        }

        /// <summary>
        /// Gets the Bot destroyed.
        /// </summary>
        public Bot Bot { get; }
    }
}