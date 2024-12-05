namespace ContentAPI.Patches.Generic
{
#pragma warning disable SA1313
#pragma warning disable SA1402
    using HarmonyLib;

    using BotAPI = global::Bot;

    /// <summary>
    /// Patch for destroying Bots.
    /// </summary>
    [HarmonyPatch(typeof(BotAPI), nameof(BotAPI.OnDestroy))]
    internal class BotSpawnPatch
    {
        private static void Postfix(BotAPI __instance)
        {
            API.Features.Bots.Bot.Get(__instance).Remove();
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_BarnacleBall), nameof(Bot_BarnacleBall.Start))]
    internal class BotSpawnPatch_BarnacleBall
    {
        private static void Postfix(Bot_BarnacleBall __instance)
        {
            _ = new API.Features.Bots.BarnacleBall(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_BigSlap), nameof(Bot_BigSlap.Start))]
    internal class BotSpawnPatch_BigSlap
    {
        private static void Postfix(Bot_BigSlap __instance)
        {
            _ = new API.Features.Bots.BigSlap(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_CameraCreep), nameof(Bot_CameraCreep.Start))]
    internal class BotSpawnPatch_CameraCreep
    {
        private static void Postfix(Bot_CameraCreep __instance)
        {
            _ = new API.Features.Bots.CameraCreep(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Chaser), nameof(Bot_Chaser.Start))]
    internal class BotSpawnPatch_Chaser
    {
        private static void Postfix(Bot_Chaser __instance)
        {
            _ = new API.Features.Bots.Chaser(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Drag), nameof(Bot_Drag.Start))]
    internal class BotSpawnPatch_Drag
    {
        private static void Postfix(Bot_Drag __instance)
        {
            _ = new API.Features.Bots.Drag(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Ear), nameof(Bot_Ear.Start))]
    internal class BotSpawnPatch_Ear
    {
        private static void Postfix(Bot_Ear __instance)
        {
            _ = new API.Features.Bots.Ear(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_EyeGuy), nameof(Bot_EyeGuy.Start))]
    internal class BotSpawnPatch_EyeGuy
    {
        private static void Postfix(Bot_EyeGuy __instance)
        {
            _ = new API.Features.Bots.EyeGuy(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Fear), nameof(Bot_Fear.Start))]
    internal class BotSpawnPatch_Fear
    {
        private static void Postfix(Bot_Fear __instance)
        {
            _ = new API.Features.Bots.Fear(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Ghost), nameof(Bot_Ghost.Start))]
    internal class BotSpawnPatch_Ghost
    {
        private static void Postfix(Bot_Ghost __instance)
        {
            _ = new API.Features.Bots.Ghost(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Infiltrator), nameof(Bot_Infiltrator.Awake))]
    internal class BotSpawnPatch_Infiltrator
    {
        private static void Postfix(Bot_Infiltrator __instance)
        {
            _ = new API.Features.Bots.Infiltrator(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Jelly), nameof(Bot_Jelly.Start))]
    internal class BotSpawnPatch_Jelly
    {
        private static void Postfix(Bot_Jelly __instance)
        {
            _ = new API.Features.Bots.Jelly(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Knifo), nameof(Bot_Knifo.Start))]
    internal class BotSpawnPatch_Knifo
    {
        private static void Postfix(Bot_Knifo __instance)
        {
            _ = new API.Features.Bots.Knifo(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_LookY), nameof(Bot_LookY.Start))]
    internal class BotSpawnPatch_LookY
    {
        private static void Postfix(Bot_LookY __instance)
        {
            _ = new API.Features.Bots.LookY(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_MimicInfiltrator), nameof(Bot_MimicInfiltrator.Awake))]
    internal class BotSpawnPatch_MimicInfiltrator
    {
        private static void Postfix(Bot_MimicInfiltrator __instance)
        {
            _ = new API.Features.Bots.MimicInfiltrator(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Mouth), nameof(Bot_Mouth.Start))]
    internal class BotSpawnPatch_Mouth
    {
        private static void Postfix(Bot_Mouth __instance)
        {
            _ = new API.Features.Bots.Mouth(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Skinny), nameof(Bot_Skinny.Start))]
    internal class BotSpawnPatch_Skinny
    {
        private static void Postfix(Bot_Skinny __instance)
        {
            _ = new API.Features.Bots.Skinny(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Snactcho), nameof(Bot_Snactcho.Start))]
    internal class BotSpawnPatch_Snactcho
    {
        private static void Postfix(Bot_Snactcho __instance)
        {
            _ = new API.Features.Bots.Snactcho(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_ToolkitBoy), nameof(Bot_ToolkitBoy.Start))]
    internal class BotSpawnPatch_ToolkitBoy
    {
        private static void Postfix(Bot_ToolkitBoy __instance)
        {
            _ = new API.Features.Bots.ToolkitBoy(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Wallo), nameof(Bot_Wallo.Start))]
    internal class BotSpawnPatch_Wallo
    {
        private static void Postfix(Bot_Wallo __instance)
        {
            _ = new API.Features.Bots.Wallo(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Weeping), nameof(Bot_Weeping.Start))]
    internal class BotSpawnPatch_Weeping
    {
        private static void Postfix(Bot_Weeping __instance)
        {
            _ = new API.Features.Bots.Weeping(__instance.gameObject);
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Zombie), nameof(Bot_Zombie.Start))]
    internal class BotSpawnPatch_Zombie
    {
        private static void Postfix(Bot_Zombie __instance)
        {
            _ = new API.Features.Bots.Zomboe(__instance.gameObject);
        }
    }
}