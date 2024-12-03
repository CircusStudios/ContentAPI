namespace ContentAPI.API.Features
{
    using System;
    using System.Collections.Generic;
    using ContentAPI.API.Enums;
    using ContentAPI.API.Interface;
    using Photon.Pun;
    using Steamworks;
    using UnityEngine;
    using PhotonPlayer = Photon.Realtime.Player;
    using PlayerAPI = global::Player;

    /// <summary>
    /// Player Wrapper.
    /// </summary>
    public class Player : IWrapper<PlayerAPI>, IWorldSpace
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
                playerAPI = value ?? throw new NullReferenceException("Player reference cannot be null!");
                playerRefs = value.refs;
                playerData = value.data;
            }
        }

        /// <inheritdoc/>
        public Vector3 Position
        {
            get => playerRefs.ragdoll.GetBodypart(BodypartType.Hip).rig.position;
            set => playerRefs.ragdoll.GetBodypart(BodypartType.Hip).rig.position = value;
        }

        /// <inheritdoc/>
        public Quaternion Rotation
        {
            get => playerRefs.ragdoll.GetBodypart(BodypartType.Hip).rig.rotation;
            set => playerRefs.ragdoll.GetBodypart(BodypartType.Hip).rig.rotation = value;
        }

        /// <summary>
        /// Gets Photon Class responsible for Networking Aspects.
        /// </summary>
        public PhotonView PhotonView => playerData.player.photonView;

        /// <summary>
        /// Gets Photon Class responsible for Networking Aspects.
        /// </summary>
        public PhotonPlayer PhotonPlayer => PhotonView.Controller;

        /// <summary>
        /// Gets the SteamId of the player.
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
                if (!PhotonNetwork.InRoom)
                    return false;

                if (SteamID == null)
                    return false;

                if (!Lobby.LobbyOwner.HasValue)
                    return false;

                return SteamMatchmaking.GetLobbyOwner(Lobby.LobbyOwner.Value) == SteamID;
            }
        }

        /// <summary>
        /// Gets a value indicating whether if the player is Local.
        /// </summary>
        public bool IsLocal => SteamID == SteamUser.GetSteamID();

        /// <summary>
        /// Allows the player to dance.
        /// </summary>
        /// <param name="danceType">The Type of dance.</param>
        public void Dance(DanceType danceType) => PhotonView.RPC("RPC_PlayEmote", RpcTarget.All, new object[]
        {
            (byte)danceType,
        });

        /// <summary>
        /// Makes the player ragdoll.
        /// </summary>
        /// <param name="seconds">How much time the player will remain as a ragdoll.</param>
        public void Ragdoll(float seconds = 20f) => PhotonView.RPC("RPCA_Fall", RpcTarget.All, new object[]
        {
            seconds,
        });

        /// <summary>
        /// Set the face of the player.
        /// </summary>
        /// <param name="hue">The Hue.</param>
        /// <param name="colorIndex">The Color Index.</param>
        /// <param name="faceText">Face Text.</param>
        /// <param name="faceRotation">Face Rotation.</param>
        /// <param name="faceSize">Face Size.</param>
        public void SetFace(float hue, int colorIndex, string faceText, float faceRotation, float faceSize) => PhotonView.RPC("RPCA_SetAllFaceSettings", RpcTarget.AllBuffered, new object[]
        {
            hue,
            colorIndex,
            faceText,
            faceRotation,
            faceSize,
        });

        /// <summary>
        /// Sets your face.
        /// </summary>
        /// <param name="text">The new Face.</param>
        /// <param name="safeCheck">If it checks is not blacklisted.</param>
        /// <remarks>Only for your own Character.</remarks>
        public void SetFace(string text, bool safeCheck = true)
        {
            if (!IsLocal)
                return;

            playerRefs.visor.visorFaceText.text = safeCheck ? playerRefs.visor.SafetyCheckVisorText(text) : text;
        }

        /// <summary>
        /// Creates the player object.
        /// </summary>
        /// <param name="player">The player to create object from.</param>
        internal static void CreatePlayer(PlayerAPI player) => _ = new Player(player);

        /// <summary>
        /// Creates the player object.
        /// </summary>
        /// <param name="player">The player to create object from.</param>
        internal static void DestroyPlayer(PlayerAPI player) => Dictionary.Remove(player.gameObject);
    }
}