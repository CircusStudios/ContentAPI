namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Chaser : Bot
    {
        private global::Bot_Chaser api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chaser"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Chaser(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Chaser bot))
                throw new ArgumentException("Could not find Bot_Chaser component in GameObject");

            api = bot;
        }
    }
}