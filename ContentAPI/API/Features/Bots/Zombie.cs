namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Zombie : Bot, IWrapper<Bot_Zombie>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        /// <param name="zombie">The zombie to wrap.</param>
        public Zombie(Bot_Zombie zombie)
            : base(zombie.bot)
        {
            Base = zombie;
        }

        /// <inheritdoc/>
        public new Bot_Zombie Base { get; }
    }
}