namespace ContentAPI.API.Features
{
    using System;
    using System.Collections.Generic;
    using ContentAPI.API.Interface;
    using UnityEngine;

    using PlayerAPI = global::Player;

    /// <summary>
    /// Player Wrapper.
    /// </summary>
    public class Player : IWrapper<PlayerAPI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="player">The <see cref="global::Player"/> of the player to be encapsulated.</param>
        public Player(PlayerAPI player) => this.Base = player;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the player.</param>
        public Player(GameObject gameObject)
        {
            if (!gameObject.TryGetComponent(out PlayerAPI p))
            {
                throw new NullReferenceException("Player's Component is missing!");
            }

            this.Base = p;
        }

        /// <summary>
        /// Gets a <see cref="Dictionary{TKey, TValue}"/> containing all <see cref="Player"/>'s on the lobby.
        /// </summary>
        public static Dictionary<GameObject, Player> Dictionary { get; } = new();

        /// <summary>
        /// Gets a list of all <see cref="Player"/>'s on the lobby.
        /// </summary>
        public static IReadOnlyCollection<Player> List => Dictionary.Values;

        /// <inheritdoc/>
        public PlayerAPI Base { get; }
    }
}