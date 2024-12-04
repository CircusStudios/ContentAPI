namespace ContentAPI.API.Enums
{
#pragma warning disable SA1602

    /// <summary>
    /// Status of the bells.
    /// </summary>
    public enum BellsState
    {
        Ready,
        NotReady,
        MissingPlayer,
        Recharging,
        Custom,
    }
}