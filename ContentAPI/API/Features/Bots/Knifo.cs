namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Knifo : Bot, IWrapper<Bot_Knifo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Knifo"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Knifo(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Knifo bot))
                throw new ArgumentException("Could not find Bot_Knifo component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Knifo Base { get; }
    }
}