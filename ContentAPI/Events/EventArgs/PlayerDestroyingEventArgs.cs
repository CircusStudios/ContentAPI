namespace ContentAPI.Events.EventArgs
{
    using ContentAPI.API.Features;

    /// <summary>
    /// Event args for player having been created.
    /// </summary>
    public class PlayerDestroyingEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerDestroyingEventArgs"/> class.
        /// </summary>
        /// <param name="player">The player created.</param>
        public PlayerDestroyingEventArgs(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// Gets the player created.
        /// </summary>
        public Player Player { get; }
    }
}