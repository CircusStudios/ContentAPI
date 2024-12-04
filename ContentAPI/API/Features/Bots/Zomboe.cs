namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Zomboe : Bot
    {
        private global::Bot_Zombie api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zomboe"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Zomboe(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Zombie bot))
                throw new ArgumentException("Could not find Bot_Angler component in GameObject");

            api = bot;
        }
    }
}