namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Drag : Bot, IWrapper<Bot_Drag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drag"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Drag(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Drag bot))
                throw new ArgumentException("Could not find Bot_Drag component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Drag Base { get; }
    }
}