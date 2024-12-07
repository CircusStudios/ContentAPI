namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Chaser : Bot, IWrapper<Bot_Chaser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chaser"/> class.
        /// </summary>
        /// <param name="chaser">The chaser bot to wrap.</param>
        public Chaser(Bot_Chaser chaser)
            : base(chaser.bot)
        {
            Base = chaser;
        }

        /// <inheritdoc/>
        public new Bot_Chaser Base { get; }
    }
}