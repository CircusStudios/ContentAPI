namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Wallo : Bot, IWrapper<Bot_Wallo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wallo"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Wallo(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Wallo bot))
                throw new ArgumentException("Could not find Bot_Wallo component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Wallo Base { get; }

        /// <summary>
        /// Gets or sets a value indicating the State of wallo.
        /// </summary>
        public Bot_Wallo.WalloState State
        {
            get => Base.walloState;
            set => Base.SetState(value);
        }

        /// <summary>
        /// Gets or sets the Player who wallo is targeting.
        /// </summary>
        public Player Target
        {
            get => Player.Get(Base.targetPlayer);
            set => Base.targetPlayer = value.Base;
        }

        /// <summary>
        /// Starts the steal.
        /// </summary>
        public void Steal() => Base.DoSteal();

        /// <summary>
        /// Makes the AI Drag the player.
        /// </summary>
        public void Drag() => Base.DragPlayerIn();

        /// <summary>
        /// Makes the AI Flee.
        /// </summary>
        public void Flee() => Base.GoToFailedPoint();
    }
}