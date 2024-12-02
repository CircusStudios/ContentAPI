namespace ContentAPI.API.Networking
{
    using Steamworks;

    /// <summary>
    /// Network Manager Class.
    /// </summary>
    public static class NetworkManager
    {
        private static Callback<LobbyEnter_t> lobbyEnter;
        private static Callback<LobbyCreated_t> lobbyCreated;

        /// <summary>
        /// Gets the current lobby.
        /// </summary>
        public static CSteamID Lobby { get; private set; }

        /// <summary>
        /// Gets a value indicating whether are we in a lobby?.
        /// </summary>
        public static bool InLobby { get; private set; }

        /// <summary>
        /// Method for initialize the custom network.
        /// </summary>
        internal static void Initialize()
        {
            lobbyEnter = Callback<LobbyEnter_t>.Create(OnLobbyEnter);
            lobbyCreated = Callback<LobbyCreated_t>.Create(OnLobbyCreated);
        }

        /// <summary>
        /// When the player Left the lobby.
        /// </summary>
        internal static void OnLobbyLeft()
        {
            InLobby = false;
        }

        private static void OnLobbyEnter(LobbyEnter_t param)
        {
            ContentPlugin.Log.LogDebug($"Entering lobby {param.m_ulSteamIDLobby}");

            Lobby = new CSteamID(param.m_ulSteamIDLobby);
            InLobby = true;
        }

        private static void OnLobbyCreated(LobbyCreated_t param)
        {
            ContentPlugin.Log.LogDebug($"Created lobby {param.m_eResult}");

            if (param.m_eResult == EResult.k_EResultOK)
            {
                Lobby = new CSteamID(param.m_ulSteamIDLobby);
                InLobby = true;
            }
        }
    }
}