namespace ContentAPI
{
    using BepInEx;
    using HarmonyLib;
    using UnityEngine;
    using static ContentPlugin;

    /// <summary>
    /// Handles loading the API through BepInEx.
    /// </summary>
    [BepInPlugin(ContentGuid, ContentName, ContentVersion)]
    public class ContentBepinLoad : BaseUnityPlugin
    {
        private void Awake()
        {
            gameObject.hideFlags = HideFlags.HideAndDontSave;

            _ = ContentPlugin.GameObject;
            new Harmony(ContentGuid).PatchAll();
        }
    }
}