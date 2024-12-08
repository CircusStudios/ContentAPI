namespace ContentAPI.API.Interface.Events
{
    /// <summary>
    /// Event args for events that can be allowed or denied.
    /// </summary>
    public interface IDeniableEvent
    {
        /// <summary>
        /// Gets or sets a value indicating whether or not the event is allowed to continue.
        /// </summary>
        public bool IsAllowed { get; set; }
    }
}