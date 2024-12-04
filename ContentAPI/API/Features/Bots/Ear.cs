namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Ear : Bot
    {
        private global::Bot_Ear api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ear"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Ear(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Ear bot))
                throw new ArgumentException("Could not find Bot_Ear component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Ear is Hurt.
        /// </summary>
        public bool EarHurt
        {
            get => Base.hurt;
            set => api.RPCA_EarSetHurt(value);
        }

        /// <summary>
        /// Forces the AI to flee.
        /// </summary>
        public void Flee() => api.RPCA_EarFlee();
    }
}