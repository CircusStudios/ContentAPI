namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Infiltrator : Bot, IWrapper<Bot_Infiltrator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Infiltrator"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public Infiltrator(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_Infiltrator bot))
                throw new ArgumentException("Could not find Bot_Infiltrator component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_Infiltrator Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Angry.
        /// </summary>
        public bool IsAngry
        {
            get => Base.isAngry;
            set => Base.MakeAngry();
        }

        /// <summary>
        /// Gets or sets a value indicating whether who the AI is mimcking.
        /// </summary>
        public Player MimickingPlayer
        {
            get => Player.Get(Base.mimickingPlayer);
            set => Base.mimickingPlayer = value.Base;
        }

        /// <summary>
        /// Gets or sets a value indicating whether is the target.
        /// </summary>
        public Player Target
        {
            get => Player.Get(Base.hitTarget);
            set => Base.hitTarget = value.Base;
        }

        /// <summary>
        /// Starts the Mimicking.
        /// </summary>
        /// <param name="player">The player to mimic.</param>
        /// <param name="target">The target.</param>
        public void Infiltrate(Player player, Player target) => Base.Init(player.Base, target.Base);

        /// <summary>
        /// Forces the AI to exfiltrate.
        /// </summary>
        public void Exfiltrate() => Base.Exfiltrate();

        /// <summary>
        /// Makes the AI visually angry.
        /// </summary>
        public void VisuallyAngry() => Base.RPC_AngryVisuals();

        /// <summary>
        /// Makes the AI not behave strangely.
        /// </summary>
        public void LessAwkward() => Base.MakeItLessAwkward();

        /// <summary>
        /// Resets the AI to normal behavior.
        /// </summary>
        public void Reset() => Base.ResetStates();
    }
}