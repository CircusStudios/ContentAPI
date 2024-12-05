namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Chaser : Bot, IWrapper<Bot_Chaser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chaser"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Chaser(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Chaser bot))
                throw new ArgumentException("Could not find Bot_Chaser component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Chaser Base { get; }
    }
}