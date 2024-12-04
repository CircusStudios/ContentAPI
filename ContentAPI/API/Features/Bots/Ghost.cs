namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Ghost : Bot
    {
        private global::Bot_Ghost api;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ghost"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Ghost(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Ghost bot))
                throw new ArgumentException("Could not find Bot_Ghost component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the Ghost is Stunned.
        /// </summary>
        public bool IsStunned
        {
            get => Base.hurt;
            set => api.RPCA_DisplayBlinded(value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Frenzy.
        /// </summary>
        public bool DisplayFrenzy
        {
            get => api.displayFrensy;
            set => api.RPCA_DisplayFrenzy(value);
        }

        /// <summary>
        /// Forces the player to Haunt the target.
        /// </summary>
        /// <remarks>You should use SetTarget() before using this.</remarks>
        public void HauntPlayer() => api.HauntPlayer();

        /// <summary>
        /// Makes the AI flee.
        /// </summary>
        public void Flee() => api.StartFlee();

        /// <summary>
        /// Tries to grab the player.
        /// </summary>
        public void TryGrab() => api.TryToGrabPlayer();
    }
}