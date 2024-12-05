namespace ContentAPI.API.Enums
{
    /// <summary>
    /// Status of the bells.
    /// </summary>
    public enum BellsState
    {
        /// <summary>
        /// The bell is ready.
        /// </summary>
        Ready,

        /// <summary>
        /// The bell is not ready.
        /// </summary>
        NotReady,

        /// <summary>
        /// The bell is missing a player.
        /// </summary>
        MissingPlayer,

        /// <summary>
        /// The bell is recharging.
        /// </summary>
        Recharging,

        /// <summary>
        /// Custom.
        /// </summary>
        Custom,
    }
}