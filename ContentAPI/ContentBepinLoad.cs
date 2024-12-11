namespace ContentAPI
{
    using BepInEx;

    using static ContentPlugin;

    /// <summary>
    /// Handles loading the API through BepInEx.
    /// </summary>
    [BepInPlugin(ContentGuid, ContentName, ContentVersion)]
    public class ContentBepinLoad : BaseUnityPlugin;
}