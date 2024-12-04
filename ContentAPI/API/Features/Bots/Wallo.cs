namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Wallo : Bot
    {
        private global::Bot_Wallo api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallo"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Wallo(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Wallo bot))
                throw new ArgumentException("Could not find Bot_Wallo component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets or sets a value indicating the State of wallo.
        /// </summary>
        public Bot_Wallo.WalloState State
        {
            get => api.walloState;
            set => api.SetState(value);
        }

        /// <summary>
        /// Gets or sets the Player who wallo is targeting.
        /// </summary>
        public Player Target
        {
            get => Player.Get(api.targetPlayer);
            set => api.targetPlayer = value.Base;
        }

        /// <summary>
        /// Starts the steal.
        /// </summary>
        public void Steal() => api.DoSteal();

        /// <summary>
        /// Makes the AI Drag the player.
        /// </summary>
        public void Drag() => api.DragPlayerIn();

        /// <summary>
        /// Makes the AI Flee.
        /// </summary>
        public void Flee() => api.GoToFailedPoint();
    }
}