namespace ContentAPI.Patches.Events.Player
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Reflection.Emit;
    using ContentAPI.API.Features.Bots;
    using ContentAPI.API.Features.Pools;
    using ContentAPI.Events.EventArgs.Player;
    using ContentAPI.Events.Handlers;
    using UnityEngine;

#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    using static HarmonyLib.AccessTools;

    /// <summary>
    /// Patch for when a player plays a sound.
    /// </summary>
    [HarmonyPatch(typeof(SFX_Player), nameof(SFX_Player.PlayNoise))]
    internal class PlayNoiseEvent
    {
        private static bool Prefix(ref Vector3 position, ref float distance, ref int alerts)
        {
            NoiseEventArgs args = new(position, distance, alerts, true);
            PlayerEventHandler.Noise.Invoke(args);

            if (!args.IsAllowed)
                return false;

            position = args.Position;
            distance = args.Distance;
            alerts = args.Alerts;
            return true;
        }
    }

    /// <summary>
    /// Patch for when a player plays a sound.
    /// </summary>
    [HarmonyPatch(typeof(SFX_Player), nameof(SFX_Player.PlaySFX))]
    internal class PlayNoiseEvent_PlaySFX
    {
        private static bool Prefix(SFX_Instance SFX, ref Vector3 position, ref float stepNoiseMultiplier, ref int alerts, Transform followTransform = null, SFX_Settings overrideSettings = null, float volumeMultiplier = 1f, bool loop = false, bool local = false, bool isNoise = true)
        {
            NoiseEventArgs args = new(position, stepNoiseMultiplier, alerts, true);
            PlayerEventHandler.Noise.Invoke(args);

            if (!args.IsAllowed)
                return false;

            position = args.Position;
            stepNoiseMultiplier = args.Distance;
            alerts = args.Alerts;

            return true;
        }
    }
}