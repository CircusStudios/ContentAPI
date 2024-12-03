namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using System.Linq;

    using ItemAPI = global::Item;

    /// <summary>
    /// Wrapper for Items.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="item">The <see cref="global::Item"/> to be encapsulated.</param>
        public Item(ItemAPI item)
        {
            if (Get(item.id) != null)
                return;

            Items.Add(this, item);
            Base = item;
        }

        /// <summary>
        /// Gets a list of all Items Registered in the game.
        /// </summary>
        public static List<Item> List => Items.Keys.ToList();

        /// <summary>
        /// Gets the Base Class.
        /// </summary>
        public ItemAPI Base { get; private set; }

        /// <summary>
        /// Gets dictionary to take account of all the items registered.
        /// </summary>
        internal static Dictionary<Item, ItemAPI> Items { get; } = new();

        /// <summary>
        /// Gets the <see cref="Item"/> belonging to the id, if any.
        /// </summary>
        /// <param name="id">The id of the item.</param>
        /// <returns>A <see cref="Item"/> or <see langword="null"/> if not found.</returns>
        public static Item Get(byte id)
        {
            return List.FirstOrDefault(x => x.Base.id == id);
        }
    }
}