namespace ContentAPI
{
    using BepInEx;
    using BepInEx.Logging;
    using ContentAPI.API.Monobehavior;
    using HarmonyLib;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// Base class handling loading the plugin.
    /// </summary>
    [BepInPlugin(ContentGuid, ContentName, ContentVersion)]
    [ContentWarningPlugin(ContentGuid, ContentVersion, ContentVanillaCompatible)]
    public class ContentPlugin : BaseUnityPlugin
    {
        /// <summary>
        /// The guid of the ContentAPI.
        /// </summary>
        public const string ContentGuid = "Circus.ContentAPI";
        private const string ContentName = "ContentAPI";
        private const string ContentVersion = "0.0.3";
        private const bool ContentVanillaCompatible = true;

        static ContentPlugin()
        {
            new GameObject("ContentAPI").AddComponent<ContentPlugin>();
        }

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
            Log = Logger;
            Harmony = new(ContentGuid);
            Harmony.PatchAll();

            new GameObject("ContentAPI_CustomKeybindings").AddComponent<CustomKeybind>();

            Logger.LogInfo($"Plugin {ContentGuid}@{ContentVersion} is loaded!");
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                foreach (API.Features.Player player in API.Features.Player.List)
                {
                    Log.LogInfo(player.SteamID.ToString());
                }
            }
        }
    }
}