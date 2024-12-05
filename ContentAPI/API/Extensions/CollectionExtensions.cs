namespace ContentAPI.API.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Zorro.Core;

    /// <summary>
    /// Extensions for collections.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Gets a random value from the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <typeparam name="T">The type contained by the collection.</typeparam>
        /// <returns>The random value found.</returns>
        public static T GetRandomValue<T>(this IEnumerable<T> collection)
        {
            if (collection is null)
                return default;

            T[] array = collection is T[] ar ? ar : collection.ToArray();
            return array.GetRandom();
        }
    }
}