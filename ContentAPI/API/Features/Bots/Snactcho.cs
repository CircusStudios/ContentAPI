namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Snactcho : Bot, IWrapper<Bot_Snactcho>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Snactcho"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Snactcho(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Snactcho bot))
                throw new ArgumentException("Could not find Bot_Snactcho component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Snactcho Base { get; }

        /// <summary>
        /// Gets or sets the player snatched.
        /// </summary>
        /// <remarks>Set null if you don't want anyone target.</remarks>
        public Player Snatched
        {
            get => Player.Get(Base.snatchedPlayer);
            set => Base.snatchedPlayer = value.Base;
        }

        /// <summary>
        /// Makes the AI Flee.
        /// </summary>
        public void Flee() => Base.TeleportAway();

        /// <summary>
        /// Forces the AI to try and snatch.
        /// </summary>
        public void TryToSnatch() => Base.Snatching();
    }
}