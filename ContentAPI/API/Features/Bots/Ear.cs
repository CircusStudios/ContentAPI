namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Ear : Bot, IWrapper<Bot_Ear>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ear"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Ear(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Ear bot))
                throw new ArgumentException("Could not find Bot_Ear component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Ear Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the Ear is Hurt.
        /// </summary>
        public bool EarHurt
        {
            get => Base.bot.hurt;
            set => Base.RPCA_EarSetHurt(value);
        }

        /// <summary>
        /// Forces the AI to flee.
        /// </summary>
        public void Flee() => Base.RPCA_EarFlee();
    }
}