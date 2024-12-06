namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Mouth : Bot, IWrapper<Bot_Mouth>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mouth"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Mouth(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Mouth bot))
                throw new ArgumentException("Could not find Bot_Mouth component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Mouth Base { get; }

        /// <summary>
        /// Makes the AI flee.
        /// </summary>
        public void Flee() => Base.Flee();
    }
}