namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class BigSlap : Bot
    {
        private global::Bot_BigSlap api;

        /// <summary>
        /// Initializes a new instance of the <see cref="BigSlap"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public BigSlap(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_BigSlap bot))
                throw new ArgumentException("Could not find Bot_BigSlap component in GameObject");

            api = bot;
        }
    }
}