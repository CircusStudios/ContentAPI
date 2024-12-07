namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Ear : Bot, IWrapper<Bot_Ear>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ear"/> class.
        /// </summary>
        /// <param name="ear">The ear to wrap.</param>
        public Ear(Bot_Ear ear)
            : base(ear.bot)
        {
            Base = ear;
        }

        /// <inheritdoc/>
        public new Bot_Ear Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the Ear is Hurt.
        /// </summary>
        public bool EarHurt
        {
            get => Base.bot.hurt;
            set => Base.RPCA_EarSetHurt(value);
        }

        /// <summary>
        /// Forces the AI to flee.
        /// </summary>
        public void Flee() => Base.RPCA_EarFlee();
    }
}