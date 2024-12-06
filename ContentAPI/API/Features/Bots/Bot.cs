namespace ContentAPI.API.Features.Bots
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ContentAPI.API.Interface;
    using UnityEngine;

    using BotAPI = global::Bot;

    /// <summary>
    /// Basic Wrapper for Bots.
    /// </summary>
    public class Bot : IWorldSpace, IWrapper<BotAPI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bot"/> class.
        /// </summary>
        /// <param name="bot">The <see cref="global::Bot"/> of the Bot.</param>
        public Bot(BotAPI bot)
        {
            Base = bot;
            Dictionary.Add(bot.gameObject, this);
        }

        /// <summary>
        /// Gets a <see cref="Dictionary{TKey, TValue}"/> containing all <see cref="Player"/>'s on the lobby.
        /// </summary>
        public static Dictionary<GameObject, Bot> Dictionary { get; } = new();

        /// <summary>
        /// Gets a list of all <see cref="Player"/>'s on the lobby.
        /// </summary>
        public static IReadOnlyCollection<Bot> List => Dictionary.Values;

        /// <summary>
        /// Gets base API for the bots.
        /// </summary>
        public BotAPI Base { get; }

        /// <inheritdoc/>
        public Vector3 Position
        {
            get => Base.groundTransform.position;
            set => Base.Teleport(value);
        }

        /// <inheritdoc/>
        public Quaternion Rotation
        {
            get => Quaternion.Euler(Base.syncData.lookDireciton);
            set => Base.syncData.lookDireciton = value.eulerAngles;
        }

        /// <summary>
        /// Gets or sets the bot Leader of the Group.
        /// </summary>
        public Bot Leader
        {
            get => Bot.Get(Base.patrolLeader);
            set => Base.patrolLeader = value.Base;
        }

        /// <summary>
        /// Gets or sets the patrol group members.
        /// </summary>
        public List<PatrolPoint.PatrolGroup> Group
        {
            get => Base.patrolGroups;
            set => Base.patrolGroups = value;
        }

        /// <summary>
        /// Gets a bot from <seealso cref="global::Bot"/>.
        /// </summary>
        /// <param name="bot">The basic bot.</param>
        /// <returns>The bot found.</returns>
        public static Bot Get(BotAPI bot) =>
            List.FirstOrDefault(p => p.Base == bot);

        /// <summary>
        /// Destroys all bots.
        /// </summary>
        public static void DestroyAll() => BotHandler.instance.DestroyAll();

        /// <summary>
        /// Sends an Alert to the AI.
        /// </summary>
        /// <param name="position">Position of the alert.</param>
        /// <param name="amount">Amount of alerts the ai will have.</param>
        public void Alert(Vector3 position, int amount = 1) => Base.Alert(position, amount);

        /// <summary>
        /// Moves to a specific point.
        /// </summary>
        /// <param name="position">The position to move.</param>
        public void Move(Vector3 position) => Base.WorldMoveTo(position);

        /// <summary>
        /// Looks in a direction.
        /// </summary>
        /// <param name="direction">Direction to look.</param>
        /// <param name="rotation_speed">How fast it will rotate.</param>
        public void Look(Vector3 direction, float rotation_speed = 3f) => Base.Look(direction, rotation_speed);

        /// <summary>
        /// Sets the AI in investigation mode.
        /// </summary>
        public void Investigate() => Base.Investigate();

        /// <summary>
        /// Makes the AI lose a target.
        /// </summary>
        public void LoseTarget() => Base.LoseTarget();

        /// <summary>
        /// Sets the AI target.
        /// </summary>
        /// <param name="player">the player to target.</param>
        public void SetTarget(Player player) => Base.SetTargetPlayer(player.Base);

        /// <summary>
        /// Removes the AI from Bot.
        /// </summary>
        public void RemoveAI() => Base.DoNothing();

        /// <summary>
        /// Wakes up the AI Movement.
        /// </summary>
        public void WakeUpAI() => Base.Walk();

        /// <summary>
        /// Destroys the Bot.
        /// </summary>
        public void Destroy()
        {
            Base.OnDestroy();
            Dictionary.Remove(Base.gameObject);
        }

        /// <summary>
        /// Removes the Bot from the list.
        /// </summary>
        internal void Remove()
        {
            Dictionary.Remove(Base.gameObject);
        }
    }
}