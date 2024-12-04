namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Mouth : Bot
    {
        private global::Bot_Mouth api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mouth"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Mouth(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Mouth bot))
                throw new ArgumentException("Could not find Bot_Mouth component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Makes the AI flee.
        /// </summary>
        public void Flee() => api.Flee();
    }
}