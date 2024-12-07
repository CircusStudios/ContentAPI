namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class LookY : Bot, IWrapper<Bot_LookY>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookY"/> class.
        /// </summary>
        /// <param name="lookY">The LookY to wrap.</param>
        public LookY(Bot_LookY lookY)
            : base(lookY.bot)
        {
            Base = lookY;
        }

        /// <inheritdoc/>
        public new Bot_LookY Base { get; }
    }
}