namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Fear : Bot
    {
        private global::Bot_Fear api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fear"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Fear(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Fear bot))
                throw new ArgumentException("Could not find Bot_Fear component in GameObject");

            api = bot;
        }
    }
}