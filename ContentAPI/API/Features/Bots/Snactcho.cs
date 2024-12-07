namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Snactcho : Bot, IWrapper<Bot_Snactcho>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snactcho"/> class.
        /// </summary>
        /// <param name="snactcho">The snactcho to warp.</param>
        public Snactcho(Bot_Snactcho snactcho)
            : base(snactcho.bot)
        {
            Base = snactcho;
        }

        /// <inheritdoc/>
        public new Bot_Snactcho Base { get; }

        /// <summary>
        /// Gets or sets the player snatched.
        /// </summary>
        /// <remarks>Set null if you don't want anyone target.</remarks>
        public Player Snatched
        {
            get => Player.Get(Base.snatchedPlayer);
            set => Base.snatchedPlayer = value.Base;
        }

        /// <summary>
        /// Makes the AI Flee.
        /// </summary>
        public void Flee() => Base.TeleportAway();

        /// <summary>
        /// Forces the AI to try and snatch.
        /// </summary>
        public void TryToSnatch() => Base.Snatching();
    }
}