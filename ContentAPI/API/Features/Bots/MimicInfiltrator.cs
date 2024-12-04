namespace ContentAPI.API.Features.Bots
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class MimicInfiltrator : Bot
    {
        private global::Bot_MimicInfiltrator api;

        /// <summary>
        /// Initializes a new instance of the <see cref="MimicInfiltrator"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public MimicInfiltrator(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_MimicInfiltrator bot))
                throw new ArgumentException("Could not find Bot_MimicInfiltrator component in GameObject");

            api = bot;
        }

        /// <summary>
        /// Gets a value indicating whether the bot is Infiltrating.
        /// </summary>
        public bool IsInfiltrating => api.IsInfiltrating;

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Angry.
        /// </summary>
        public bool IsAngry
        {
            get => api.isAngry;
            set => api.MakeAngry();
        }

        /// <summary>
        /// Gets or sets a value indicating whether who the AI is mimcking.
        /// </summary>
        public Player MimickingPlayer
        {
            get => Player.Get(api.mimickingPlayer);
            set => api.mimickingPlayer = value.Base;
        }

        /// <summary>
        /// Gets or sets a value indicating whether is the target.
        /// </summary>
        public Player Target
        {
            get => Player.Get(api.hitTarget);
            set => api.hitTarget = value.Base;
        }

        /// <summary>
        /// Starts the Mimicking.
        /// </summary>
        /// <param name="player">The player to mimic.</param>
        /// <param name="target">The target.</param>
        /// <param name="position">The position of the bot when mimicking.</param>
        public void Infiltrate(Player player, Player target, Vector3 position) => api.Infiltrate(player.Base, target.Base, position);

        /// <summary>
        /// Starts the Mimicking.
        /// </summary>
        /// <param name="player">The player to mimic.</param>
        /// <param name="target">The target.</param>
        public void Infiltrate(Player player, Player target) => api.MimickPlayer(player.Base, target.Base);

        /// <summary>
        /// Forces the AI to exfiltrate.
        /// </summary>
        public void Exfiltrate() => api.Despawn();

        /// <summary>
        /// Makes the AI visually angry.
        /// </summary>
        public void VisuallyAngry() => api.RPC_AngryVisuals();

        /// <summary>
        /// Makes the AI not behave strangely.
        /// </summary>
        public void LessAwkward() => api.MakeItLessAwkward();
    }
}