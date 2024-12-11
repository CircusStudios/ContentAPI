namespace ContentAPI
{
    using ContentAPI.API.Components;
    using UnityEngine;

    /// <summary>
    /// Base class handling loading the plugin.
    /// </summary>
    [ContentWarningPlugin(ContentGuid, ContentVersion, ContentVanillaCompatible)]
    public static class ContentPlugin
    {
        /// <summary>
        /// The guid of the ContentAPI.
        /// </summary>
        public const string ContentGuid = "Circus.ContentAPI";

        /// <summary>
        /// Gets the name to be used.
        /// </summary>
        public const string ContentName = "ContentAPI";

        /// <summary>
        /// Gets the version of the API.
        /// </summary>
        public const string ContentVersion = "0.0.3";

        /// <summary>
        /// Gets whether or not its compatible with vanilla.
        /// </summary>
        public const bool ContentVanillaCompatible = true;

        static ContentPlugin()
        {
            CreateObjects();
        }

        /// <summary>
        /// Gets the <see cref="GameObject"/> used by the API.
        /// </summary>
        public static GameObject GameObject { get; private set; }

        private static void CreateObjects()
        {
            GameObject = new("ContentAPI");
            GameObject.AddComponent<CustomKeybind>();
            Object.DontDestroyOnLoad(GameObject);
        }
    }
}