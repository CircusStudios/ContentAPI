namespace ContentAPI.Events.EventArgs
{
    using API.Features;

    /// <summary>
    /// Event args for player having been created.
    /// </summary>
    public class PlayerCreatedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerCreatedEventArgs"/> class.
        /// </summary>
        /// <param name="player">The player created.</param>
        public PlayerCreatedEventArgs(Player player)
        {
            Player = player;
        }

        /// <summary>
        /// Gets the player created.
        /// </summary>
        public Player Player { get; }
    }
}