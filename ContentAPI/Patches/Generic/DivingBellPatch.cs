namespace ContentAPI.Patches.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using ContentAPI.API.Features;
    using HarmonyLib;
    using Zorro.Core;

    using DivingBellAPI = global::DivingBell;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(DivingBellAPI), nameof(DivingBellAPI.Awake))]
    internal class DivingBellPatch
    {
        private static void Postfix(DivingBellAPI __instance)
        {
            _ = new DivingBell(__instance);
        }
    }
}