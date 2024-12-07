namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class MimicInfiltrator : Bot, IWrapper<Bot_MimicInfiltrator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MimicInfiltrator"/> class.
        /// </summary>
        /// <param name="mimicInfiltrator">The mimic to wrap.</param>
        public MimicInfiltrator(Bot_MimicInfiltrator mimicInfiltrator)
            : base(mimicInfiltrator.bot)
        {
            Base = mimicInfiltrator;
        }

        /// <inheritdoc/>
        public new Bot_MimicInfiltrator Base { get; }

        /// <summary>
        /// Gets a value indicating whether the bot is Infiltrating.
        /// </summary>
        public bool IsInfiltrating => Base.IsInfiltrating;

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Angry.
        /// </summary>
        public bool IsAngry
        {
            get => Base.isAngry;

            // TODO: Check value be used.
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
        /// <param name="position">The position of the bot when mimicking.</param>
        public void Infiltrate(Player player, Player target, Vector3 position) => Base.Infiltrate(player.Base, target.Base, position);

        /// <summary>
        /// Starts the Mimicking.
        /// </summary>
        /// <param name="player">The player to mimic.</param>
        /// <param name="target">The target.</param>
        public void Infiltrate(Player player, Player target) => Base.MimickPlayer(player.Base, target.Base);

        /// <summary>
        /// Forces the AI to exfiltrate.
        /// </summary>
        public void Exfiltrate() => Base.Despawn();

        /// <summary>
        /// Makes the AI visually angry.
        /// </summary>
        public void VisuallyAngry() => Base.RPC_AngryVisuals();

        /// <summary>
        /// Makes the AI not behave strangely.
        /// </summary>
        public void LessAwkward() => Base.MakeItLessAwkward();
    }
}