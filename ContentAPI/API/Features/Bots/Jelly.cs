namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Jelly : Bot, IWrapper<Bot_Jelly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jelly"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Jelly(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Jelly bot))
                throw new ArgumentException("Could not find Bot_Jelly component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Jelly Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the ai is fleeing.
        /// </summary>
        public bool IsFleeing
        {
            get => Base.fleeing;
            set => Base.RPCA_DropAndFlee();
        }
    }
}