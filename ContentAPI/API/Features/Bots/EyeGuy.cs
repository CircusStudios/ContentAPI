namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class EyeGuy : Bot, IWrapper<Bot_EyeGuy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EyeGuy"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public EyeGuy(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_EyeGuy bot))
                throw new ArgumentException("Could not find Bot_EyeGuy component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_EyeGuy Base { get; }
    }
}