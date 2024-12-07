namespace ContentAPI.Patches.Generic
{
    using ContentAPI.API.Features.Bots;

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
            Bot.Get(__instance).Remove();
        }
    }

    /// <summary>
    /// Patch for adding Bots.
    /// </summary>
    [HarmonyPatch(typeof(Bot_Angler), nameof(Bot_Angler.Start))]
    internal class BotSpawnPatch_Angler
    {
        private static void PostFix(Bot_Angler __instance)
        {
            _ = new Angler(__instance);
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
            _ = new BarnacleBall(__instance);
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
            _ = new BigSlap(__instance);
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
            _ = new CameraCreep(__instance);
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
            _ = new Chaser(__instance);
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
            _ = new Drag(__instance);
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
            _ = new Ear(__instance);
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
            _ = new EyeGuy(__instance);
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
            _ = new Fear(__instance);
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
            _ = new Ghost(__instance);
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
            _ = new Infiltrator(__instance);
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
            _ = new Jelly(__instance);
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
            _ = new Knifo(__instance);
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
            _ = new LookY(__instance);
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
            _ = new MimicInfiltrator(__instance);
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
            _ = new Mouth(__instance);
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
            _ = new Skinny(__instance);
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
            _ = new Snactcho(__instance);
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
            _ = new ToolkitBoy(__instance);
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
            _ = new Wallo(__instance);
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
            _ = new Weeping(__instance);
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
            _ = new Zombie(__instance);
        }
    }
}