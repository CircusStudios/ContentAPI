namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Knifo : Bot
    {
        private global::Bot_Knifo api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Knifo"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Knifo(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Knifo bot))
                throw new ArgumentException("Could not find Bot_Knifo component in GameObject");

            api = bot;
        }
    }
}