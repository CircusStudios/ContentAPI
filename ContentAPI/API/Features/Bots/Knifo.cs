namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Knifo : Bot, IWrapper<Bot_Knifo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Knifo"/> class.
        /// </summary>
        /// <param name="knifo">The knifo to wrap.</param>
        public Knifo(Bot_Knifo knifo)
            : base(knifo.bot)
        {
            Base = knifo;
        }

        /// <inheritdoc/>
        public new Bot_Knifo Base { get; }
    }
}