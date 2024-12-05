namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Fear : Bot, IWrapper<Bot_Fear>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fear"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Fear(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Fear bot))
                throw new ArgumentException("Could not find Bot_Fear component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Fear Base { get; }
    }
}