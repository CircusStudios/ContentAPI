namespace ContentAPI
{
    using BepInEx;
    using BepInEx.Logging;
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
        private const string ContentVersion = "0.0.1";
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

        private void Awake()
        {
            Instance = this;
            Log = Logger;
            Harmony = new(ContentGUID);
            Harmony.PatchAll();

            Logger.LogInfo($"Plugin {ContentGUID}@{ContentVersion} is loaded!");
        }
    }
}