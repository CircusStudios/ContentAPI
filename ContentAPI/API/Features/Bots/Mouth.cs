namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Mouth : Bot, IWrapper<Bot_Mouth>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mouth"/> class.
        /// </summary>
        /// <param name="mouth">The mouth to wrap.</param>
        public Mouth(Bot_Mouth mouth)
            : base(mouth.gameObject)
        {
            Base = mouth;
        }

        /// <inheritdoc/>
        public new Bot_Mouth Base { get; }

        /// <summary>
        /// Makes the AI flee.
        /// </summary>
        public void Flee() => Base.Flee();
    }
}