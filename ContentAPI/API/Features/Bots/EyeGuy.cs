namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class EyeGuy : Bot
    {
        private global::Bot_EyeGuy api;

        /// <summary>
        /// Initializes a new instance of the <see cref="EyeGuy"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public EyeGuy(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_EyeGuy bot))
                throw new ArgumentException("Could not find Bot_EyeGuy component in GameObject");

            api = bot;
        }
    }
}