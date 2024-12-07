namespace ContentAPI
{
    using BepInEx;
    using BepInEx.Logging;
    using ContentAPI.Events.EventArgs;
    using HarmonyLib;

    /// <summary>
    /// Base class handling loading the plugin.
    /// </summary>
    [BepInPlugin(ContentGUID, ContentName, ContentVersion)]
    [ContentWarningPlugin(ContentGUID, ContentVersion, ContentVanillaCompatible)]
    public class ContentPlugin : BaseUnityPlugin
    {
        private const string ContentGUID = "Circus.ContentAPI";
        private const string ContentName = "ContentAPI";
        private const string ContentVersion = "1.0.0";
        private const bool ContentVanillaCompatible = true;

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

        /// <summary>
        /// Test Events.
        /// </summary>
        /// <param name="ev">UwU.</param>
        public void Test(PlayerCreatedEventArgs ev)
        {
            Log.LogInfo($"Test {ev.Player.SteamID}");
        }

        private void Awake()
        {
            Instance = this;
            Log = Logger;
            Harmony = new(ContentGUID);
            Harmony.PatchAll();

            Events.Handlers.PlayerEventHandler.PlayerCreated.AddListener(Test);

            Logger.LogInfo($"Plugin {ContentGUID}@{ContentVersion} is loaded!");
        }
    }
}