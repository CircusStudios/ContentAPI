namespace ContentAPI.Patches.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using ContentAPI.API.Features;
    using ContentAPI.Events.Handlers;
    using HarmonyLib;

    /// <summary>
    /// Patch for Adding the shop Handler.
    /// </summary>
    [HarmonyPatch(typeof(ShopHandler), nameof(ShopHandler.InitShopHandler))]
    internal class ShopHandlerPatch
    {
        private static void Postfix(ShopHandler __instance)
        {
            _ = new Shop(__instance);
        }
    }
}