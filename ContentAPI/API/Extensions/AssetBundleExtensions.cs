namespace ContentAPI.API.Extensions
{
    using UnityEngine;

    /// <summary>
    /// Extensions related to asset bundles.
    /// </summary>
    public static class AssetBundleExtensions
    {
        /// <summary>
        /// Gets an asset bundle from a path.
        /// </summary>
        /// <param name="path">The path to get the bundle from.</param>
        /// <returns>The asset bundle found.</returns>
        public static AssetBundle GetAssetBundle(this string path) => AssetBundle.LoadFromFile(path);
    }
}