namespace ContentAPI.Events.EventArgs.Player
{
    using ContentAPI.API.Interface.Events;
    using TMPro;
    using UnityEngine;

    /// <summary>
    /// Event args for when a player does a noise.
    /// </summary>
    public class DivingBellTextEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivingBellTextEventArgs"/> class.
        /// </summary>
        /// <param name="player">The player being referenced in the text.</param>
        /// <param name="name">Text for the name.</param>
        /// <param name="oxygen">Text for the oxygen.</param>
        /// <param name="distance_text">Text for the distance.</param>
        /// <param name="distance">The distance between the player and the bell.</param>
        public DivingBellTextEventArgs(API.Features.Player player, TextMeshProUGUI name, TextMeshProUGUI oxygen, TextMeshProUGUI distance_text, float distance)
        {
            Player = player;
            Name = name;
            Oxygen = oxygen;
            DistanceText = distance_text;
            Distance = distance;
        }

        /// <summary>
        /// Gets the player being referenced.
        /// </summary>
        public API.Features.Player Player { get; }

        /// <summary>
        /// Gets the Text for the name.
        /// </summary>
        public TextMeshProUGUI Name { get; }

        /// <summary>
        /// Gets the Text for the Oxygen.
        /// </summary>
        public TextMeshProUGUI Oxygen { get; }

        /// <summary>
        /// Gets the Text for the name distance.
        /// </summary>
        public TextMeshProUGUI DistanceText { get; }

        /// <summary>
        /// Gets the distance between the player and the bell.
        /// </summary>
        public float Distance { get; }
    }
}