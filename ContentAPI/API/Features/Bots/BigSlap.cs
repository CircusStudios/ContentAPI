namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class BigSlap : Bot, IWrapper<Bot_BigSlap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BigSlap"/> class.
        /// </summary>
        /// <param name="bigSlap">The big slap to wrap.</param>
        public BigSlap(Bot_BigSlap bigSlap)
            : base(bigSlap.bot)
        {
            Base = bigSlap;
        }

        /// <inheritdoc/>
        public new Bot_BigSlap Base { get; }
    }
}