namespace ContentAPI.Events.EventArgs.Monsters
{
    using ContentAPI.API.Features.Bots;
    using ContentAPI.API.Interface.Events;
    using UnityEngine;

    /// <summary>
    /// Event args for bot being Alerted.
    /// </summary>
    public class MonsterAlertEventArgs : IDeniableEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterAlertEventArgs"/> class.
        /// </summary>
        /// <param name="bot">The Bot alerted.</param>
        /// <param name="position">The position of the alert.</param>
        /// <param name="alerts">The amount of the alert.</param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed" /></param>
        public MonsterAlertEventArgs(Bot bot, Vector3 position, int alerts, bool isAllowed = true)
        {
            Bot = bot;
            Position = position;
            Alerts = alerts;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets the Bot created.
        /// </summary>
        public Bot Bot { get; }

        /// <summary>
        /// Gets or sets the position of the alert.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the amount of the alert.
        /// </summary>
        public int Alerts { get; set; }

        /// <inheritdoc cref="IsAllowed" />
        public bool IsAllowed { get; set; }
    }
}