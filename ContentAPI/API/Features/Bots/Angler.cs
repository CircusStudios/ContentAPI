namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Angler : Bot, IWrapper<Bot_Angler>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Angler"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Angler(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Angler bot))
                throw new ArgumentException("Could not find Bot_Angler component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Angler Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the bot is sucking.
        /// </summary>
        public bool IsSucking
        {
            get => Base.isSucking;
            set => Base.isSucking = value;
        }

        /// <summary>
        /// Gets or sets the player to mimic.
        /// </summary>
        public Player PlayerToMimic
        {
            get => Player.Get(Base.mimicingPlayer);
            set => Base.mimicingPlayer = value.Base;
        }

        /// <summary>
        /// Spawns the mimic.
        /// </summary>
        public void SpawnMimic() => Base.SpawnMimic();

        /// <summary>
        /// Forces the bot to find someone to mimic.
        /// </summary>
        public void ForceFind() => Base.FindAndSetPlayerToMimic();
    }
}