namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using System;
    using ContentAPI.API.Features;
    using HarmonyLib;
    using UnityEngine;

    using PickupAPI = global::Pickup;

    /// <summary>
    /// Patch for adding Pickup.
    /// </summary>
    [HarmonyPatch(typeof(PickupAPI), nameof(PickupAPI.Awake))]
    internal class PickupWrapPatch
    {
        private static void Postfix(PickupAPI __instance)
        {
            _ = new Pickup(__instance);
        }
    }

    /// <summary>
    /// Patch for removing Pickup.
    /// </summary>
    [HarmonyPatch(typeof(PickupAPI), nameof(PickupAPI.OnDisable))]
    internal class PickupWrapPatch_Remove
    {
        private static void Postfix(PickupAPI __instance)
        {
            Pickup.Items.Remove(Pickup.Get(__instance.m_itemID));
        }
    }
}