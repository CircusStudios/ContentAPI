namespace ContentAPI.Patch.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using System;
    using HarmonyLib;
    using UnityEngine;

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PickupHandler), nameof(PickupHandler.CreatePickup), new Type[] { typeof(byte), typeof(ItemInstanceData), typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Vector3) })]
    internal class SpawnPickup
    {
        private static void Postfix(Pickup __result)
        {
            ContentPlugin.Log.LogInfo($"Spawning pickup {__result.gameObject.name}");
        }
    }

    /// <summary>
    /// Patch for adding Players.
    /// </summary>
    [HarmonyPatch(typeof(PickupHandler), nameof(PickupHandler.CreatePickup), new Type[] { typeof(byte), typeof(ItemInstanceData), typeof(Vector3), typeof(Quaternion) })]
    internal class SpawnPickup2
    {
        private static void Postfix(Pickup __result)
        {
            ContentPlugin.Log.LogInfo($"Spawning pickup {__result.gameObject.name}");
        }
    }
}