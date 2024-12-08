namespace ContentAPI.Events.EventArgs.Player
{
    using ContentAPI.API.Interface.Events;
    using UnityEngine;

    /// <summary>
    /// Event args for when a player does a noise.
    /// </summary>
    public class NoiseEventArgs : IDeniableEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoiseEventArgs"/> class.
        /// </summary>
        /// <param name="position">The position of the sound.</param>
        /// <param name="distance">How far the sound will travel.</param>
        /// <param name="alerts">How many trigger for the AI.</param>
        /// <param name="isAllowed"><inheritdoc cref="IsAllowed" /></param>
        public NoiseEventArgs(Vector3 position, float distance, int alerts, bool isAllowed = true)
        {
            Position = position;
            Distance = distance;
            Alerts = alerts;
            IsAllowed = isAllowed;
        }

        /// <summary>
        /// Gets or sets Position of the sound.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets how far the sound will travel.
        /// </summary>
        public float Distance { get; set; }

        /// <summary>
        /// Gets or sets How many trigger for the AI.
        /// </summary>
        public int Alerts { get; set; }

        /// <inheritdoc />
        public bool IsAllowed { get; set; }
    }
}