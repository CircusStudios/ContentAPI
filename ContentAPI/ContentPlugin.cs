namespace ContentAPI
{
    using BepInEx;

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

        private void Awake()
        {
            Instance = this;

            Logger.LogInfo($"Plugin {ContentGUID}@{ContentVersion} is loaded!");
        }
    }
}