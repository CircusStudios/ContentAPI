namespace ContentAPI.Patches.Fixes
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;
    using UnityEngine;
    using Zorro.Core.CLI;

    /// <summary>
    /// Patch for adding back the debug ui.
    /// </summary>
    [HarmonyPatch(typeof(DebugUIHandler), "Update")]
    internal class DebugUIHandlerPatch
    {
        private static void Postfix(DebugUIHandler __instance)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                if (__instance.IsOpen)
                    __instance.Hide();
                else
                    __instance.Show();
            }
        }
    }
}