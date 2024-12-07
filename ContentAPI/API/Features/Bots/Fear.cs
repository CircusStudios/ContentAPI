namespace ContentAPI.API.Features.Bots
{
    using ContentAPI.API.Interface;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Fear : Bot, IWrapper<Bot_Fear>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fear"/> class.
        /// </summary>
        /// <param name="fear">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Fear(Bot_Fear fear)
            : base(fear.bot)
        {
            Base = fear;
        }

        /// <inheritdoc/>
        public new Bot_Fear Base { get; }
    }
}