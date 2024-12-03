namespace ContentAPI.API.Features
{
    using Photon.Pun;
    using Steamworks;

    /// <summary>
    /// Gets the lobby data.
    /// </summary>
    public static class Lobby
    {
        /// <summary>
        /// Gets instance of the RoomStatsHolder.
        /// </summary>
        public static RoomStatsHolder Instance { get; } = SurfaceNetworkHandler.RoomStats;

        /// <summary>
        /// Gets the lobby Owner.
        /// </summary>
        public static CSteamID LobbyOwner { get; } = SurfaceNetworkHandler.Instance.m_SteamLobby.LobbyOwner;

        /// <summary>
        /// Gets or sets days for a Qutoa.
        /// </summary>
        public static int DaysPerQuota
        {
            get => Instance.DaysPerQutoa;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.DaysPerQutoa = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets Money.
        /// </summary>
        public static int Money
        {
            get => Instance.Money;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.Money = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets CurrentDay.
        /// </summary>
        public static int CurrentDay
        {
            get => Instance.CurrentDay;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.CurrentDay = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets CurrentQuotaDay.
        /// </summary>
        public static int CurrentQuotaDay
        {
            get => Instance.CurrentQuotaDay;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.CurrentQuotaDay = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets QuotaToReach.
        /// </summary>
        public static int QuotaToReach
        {
            get => Instance.QuotaToReach;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.QuotaToReach = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets CurrentQuota.
        /// </summary>
        public static int CurrentQuota
        {
            get => Instance.CurrentQuota;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.CurrentQuota = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player recived the Quota.
        /// </summary>
        public static bool ReceivedQuota
        {
            get => Instance.ReceivedQuota;
            set
            {
                if (!PhotonNetwork.IsMasterClient)
                    return;

                Instance.ReceivedQuota = value;
                Instance.OnStatsUpdated();
            }
        }

        /// <summary>
        /// Gets or sets the seed of the Map.
        /// </summary>
        /// <remarks>if set to -1, it will regenerate.</remarks>
        public static int Seed
        {
            get => Instance.MatchSeed;
            set
            {
                if (value == -1)
                    Instance.RegenerateSeed();
                else
                    Instance.MatchSeed = value;
            }
        }

        /// <summary>
        /// Gets or sets the level to Play.
        /// </summary>
        /// <remarks>if set to -1, it will regenerate.</remarks>
        public static int LevelToPlay
        {
            get => Instance.LevelToPlay;
            set
            {
                if (value == -1)
                    Instance.NewMapToPlay();
                else
                    Instance.LevelToPlay = value;
            }
        }

        /// <summary>
        /// Gets CurrentRun.
        /// </summary>
        public static int CurrentRun { get; } = Instance.CurrentRun;

        /// <summary>
        /// Gets a value indicating whether the computer room is unlocked.
        /// </summary>
        public static bool ComputerRoomIsUnlocked { get; } = Instance.ComputerRoomDoorUnlocked;

        /// <summary>
        /// Gets a value indicating whether the day is the max for the quota.
        /// </summary>
        public static bool IsQuotaDay { get; } = Instance.IsQuotaDay;
    }
}