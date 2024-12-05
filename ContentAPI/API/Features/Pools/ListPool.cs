namespace ContentAPI.API.Features.Pools
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// List pool.
    /// </summary>
    /// <typeparam name="T">The type for the list to contain.</typeparam>
    public class ListPool<T>
    {
        private readonly ConcurrentQueue<List<T>> pool = new();

        /// <summary>
        /// Gets a <see cref="ListPool{T}"/> that stores lists.
        /// </summary>
        public static ListPool<T> Pool { get; } = new();

        /// <summary>
        /// Rents a <see cref="List{T}"/>.
        /// </summary>
        /// <returns>The list rented.</returns>
        public List<T> Rent() => pool.TryDequeue(out List<T> result) ? result : new(512);

        /// <summary>
        /// Rents a <see cref="List{T}"/>.
        /// </summary>
        /// <param name="enumerable">The existing items for the list to contain.</param>
        /// <returns>The list rented.</returns>
        public List<T> Rent(IEnumerable<T> enumerable)
        {
            if (!pool.TryDequeue(out List<T> result))
                return new(enumerable);

            result.AddRange(enumerable);
            return result;
        }

        /// <summary>
        /// Returns the list to the pool to be reused.
        /// </summary>
        /// <param name="list">The list to return.</param>
        public void Return(List<T> list)
        {
            list.Clear();
            pool.Enqueue(list);
        }
    }
}