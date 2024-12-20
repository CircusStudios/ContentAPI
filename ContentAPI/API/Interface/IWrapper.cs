namespace ContentAPI.API.Interface
{
    /// <summary>
    /// Defines the contract for classes that wrap a base-game object.
    /// </summary>
    /// <typeparam name="T">The base-game class that is being wrapped.</typeparam>
    public interface IWrapper<T>
    {
        /// <summary>
        /// Gets the base <typeparamref name="T"/> that this class is wrapping.
        /// </summary>
        public T Base { get; }
    }
}