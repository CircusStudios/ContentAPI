namespace ContentAPI.API.Features
{
    using System;
    using System.Collections.Generic;
    using ContentAPI.API.Interface;
    using ContentAPI.API.Networking;
    using Photon.Pun;
    using Steamworks;
    using UnityEngine;
    using PhotonPlayer = Photon.Realtime.Player;
    using PlayerAPI = global::Player;

    /// <summary>
    /// Player Wrapper.
    /// </summary>
    public class Player : IWrapper<PlayerAPI>
    {
        private PlayerAPI playerAPI;
        private PlayerAPI.PlayerRefs playerRefs;
        private PlayerAPI.PlayerData playerData;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="player">The <see cref="global::Player"/> of the player to be encapsulated.</param>
        internal Player(PlayerAPI player)
        {
            Base = player;
            Dictionary.Add(player.gameObject, this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the player.</param>
        internal Player(GameObject gameObject)
        {
            if (!gameObject.TryGetComponent(out PlayerAPI player))
                throw new ArgumentException("Could not find Player component in GameObject");

            Base = player;
            Dictionary.Add(gameObject, this);
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
        public PlayerAPI Base
        {
            get => playerAPI;
            private set
            {
                playerAPI = value ?? throw new NullReferenceException("Player's ReferenceHub cannot be null!");
                playerRefs = value.refs;
                playerData = value.data;
            }
        }

        /// <summary>
        /// Gets Photon Class responsable for Networking Aspects.
        /// </summary>
        public PhotonPlayer PhotonPlayer => Base.data.player.photonView.Controller;

        /// <summary>
        /// Gets the SteamId.
        /// </summary>
        /// <remarks>It can be null.</remarks>>
        public CSteamID? SteamID => SteamAvatarHandler.TryGetSteamIDForPlayer(PhotonPlayer, out CSteamID steamID) ? steamID : null;

        /// <summary>
        /// Gets a value indicating whether the player is the lobby owner.
        /// </summary>
        public bool IsLobbyOwner
        {
            get
            {
                if (!NetworkManager.InLobby)
                    return false;

                if (SteamID == null)
                    return false;

                return SteamMatchmaking.GetLobbyOwner(NetworkManager.Lobby) == SteamID;
            }
        }

        /// <summary>
        /// Creates the player object.
        /// </summary>
        /// <param name="player">The player to create object from.</param>
        internal static void CreatePlayer(PlayerAPI player) => _ = new Player(player);
    }
}