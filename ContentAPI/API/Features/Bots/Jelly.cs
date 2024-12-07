namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Jelly : Bot, IWrapper<Bot_Jelly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jelly"/> class.
        /// </summary>
        /// <param name="jelly">The jelly to wrap.</param>
        public Jelly(Bot_Jelly jelly)
            : base(jelly.bot)
        {
            Base = jelly;
        }

        /// <inheritdoc/>
        public new Bot_Jelly Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the ai is fleeing.
        /// </summary>
        public bool IsFleeing
        {
            get => Base.fleeing;
            set => Base.RPCA_DropAndFlee();
        }
    }
}