namespace ContentAPI.Events.EventArgs
{
    using ContentAPI.API.Features;

    /// <summary>
    /// Event args for player having been created.
    /// </summary>
    public class PlayerDestroyedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerDestroyedEventArgs"/> class.
        /// </summary>
        /// <param name="player">The player created.</param>
        public PlayerDestroyedEventArgs(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// Gets the player created.
        /// </summary>
        public Player Player { get; }
    }
}