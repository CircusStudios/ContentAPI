namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Ghost : Bot, IWrapper<Bot_Ghost>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ghost"/> class.
        /// </summary>
        /// <param name="ghost">The ghost to wrap.</param>
        public Ghost(Bot_Ghost ghost)
            : base(ghost.bot)
        {
            Base = ghost;
        }

        /// <inheritdoc/>
        public new Bot_Ghost Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the Ghost is Stunned.
        /// </summary>
        public bool IsStunned
        {
            get => Base.hurt;
            set => Base.RPCA_DisplayBlinded(value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Frenzy.
        /// </summary>
        public bool DisplayFrenzy
        {
            get => Base.displayFrensy;
            set => Base.RPCA_DisplayFrenzy(value);
        }

        /// <summary>
        /// Forces the player to Haunt the target.
        /// </summary>
        /// <remarks>You should use SetTarget() before using this.</remarks>
        public void HauntPlayer() => Base.HauntPlayer();

        /// <summary>
        /// Makes the AI flee.
        /// </summary>
        public void Flee() => Base.StartFlee();

        /// <summary>
        /// Tries to grab the player.
        /// </summary>
        public void TryGrab() => Base.TryToGrabPlayer();
    }
}