namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class LookY : Bot
    {
        private global::Bot_LookY api;

        /// <summary>
        /// Initializes a new instance of the <see cref="LookY"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public LookY(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_LookY bot))
                throw new ArgumentException("Could not find Bot_LookY component in GameObject");

            api = bot;
        }
    }
}