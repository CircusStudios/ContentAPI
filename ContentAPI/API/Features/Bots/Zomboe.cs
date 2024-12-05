namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Zomboe : Bot, IWrapper<Bot_Zombie>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zomboe"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Zomboe(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Zombie bot))
                throw new ArgumentException("Could not find Bot_Angler component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Zombie Base { get; }
    }
}