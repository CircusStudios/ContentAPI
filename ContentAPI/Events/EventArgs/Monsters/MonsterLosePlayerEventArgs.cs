namespace ContentAPI.Events.EventArgs.Monsters
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.API.Interface.Events;
    using UnityEngine;

    /// <summary>
    /// Event args for bot loosing a target.
    /// </summary>
    public class MonsterLosePlayerEventArgs : IDeniableEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterLosePlayerEventArgs"/> class.
        /// </summary>
        /// <param name="bot">The Bot alerted.</param>
        /// <param name="player">The player who the AI lost track / wasn't interested anymore.</param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed" /></param>
        public MonsterLosePlayerEventArgs(Bot bot, API.Features.Player player, bool isAllowed = true)
        {
            Bot = bot;
            Player = player;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the Bot created.
        /// </summary>
        public Bot Bot { get; }

        /// <summary>
        /// Gets the position of the alert.
        /// </summary>
        public API.Features.Player Player { get; }

        /// <inheritdoc cref="IsAllowed" />
        public bool IsAllowed { get; set; }
    }
}