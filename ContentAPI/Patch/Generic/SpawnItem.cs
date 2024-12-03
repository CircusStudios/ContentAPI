namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using ContentAPI.API.Features;
    using HarmonyLib;
    using Zorro.Core;

    using ItemAPI = global::Item;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(GameHandler), nameof(GameHandler.Initialize))]
    internal class SpawnItem
    {
        private static void Postfix(GameHandler __instance)
        {
            foreach (ItemAPI item in SingletonAsset<ItemDatabase>.Instance.Objects)
            {
                _ = new Item(item);
            }
        }
    }
}