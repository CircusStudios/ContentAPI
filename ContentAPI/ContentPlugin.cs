// <copyright file="ContentPlugin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace ContentAPI
{
    using System.Linq;
    using BepInEx;
    using BepInEx.Logging;
    using ContentAPI.API.Networking;
    using HarmonyLib;
    using Steamworks;
    using UnityEngine;
    using UnityEngine.Windows;
    using Input = UnityEngine.Input;

    /// <summary>
    /// Base class handling loading the plugin.
    /// </summary>
    [BepInPlugin(ContentGUID, ContentName, ContentVersion)]
    public class ContentPlugin : BaseUnityPlugin
    {
        private const string ContentGUID = "Circus.ContentAPI";
        private const string ContentName = "ContentAPI";
        private const string ContentVersion = "1.0.0";

        /// <summary>
        /// Gets the instance of the plugin.
        /// </summary>
        public static ContentPlugin Instance { get; private set; }

        /// <summary>
        /// Gets the plugin Logger.
        /// </summary>
        internal static ManualLogSource Log { get; private set; }

        /// <summary>
        /// Gets the Harmony.
        /// </summary>
        internal static Harmony Harmony { get; private set; }

        private void Awake()
        {
            Instance = this;
            Log = this.Logger;
            Harmony = new Harmony(ContentGUID);
            Harmony.PatchAll();

            NetworkManager.Initialize();

            this.Logger.LogInfo($"Plugin {ContentGUID}@{ContentVersion} is loaded!");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                foreach (API.Features.Player player2 in API.Features.Player.List)
                {
                    this.Logger.LogInfo(player2.IsLobbyOwner + " SteamID: " + player2.SteamID.Value.m_SteamID);
                }
            }
        }
    }
}