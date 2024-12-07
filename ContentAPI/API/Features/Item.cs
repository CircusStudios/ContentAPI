namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using ContentAPI.API.Enums;
    using ContentAPI.API.Interface;
    using ItemAPI = global::Item;

    /// <summary>
    /// Wrapper for Items.
    /// </summary>
    public class Item : IWrapper<ItemAPI>
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
        /// Gets the <see cref="ItemType"/>.
        /// </summary>
        public ItemType Type => (ItemType)Base.id;

        /// <summary>
        /// Gets or sets the rarity at which the item spawns.
        /// </summary>
        public RARITY SpawnRarity
        {
            get => Base.toolSpawnRarity;
            set => Base.toolSpawnRarity = value;
        }

        /// <summary>
        /// Gets or sets the price of item.
        /// </summary>
        public int Price
        {
            get => Base.price;
            set => Base.price = value;
        }

        /// <summary>
        /// Gets the shop category of the item.
        /// </summary>
        public ShopItemCategory ShopCategory => Base.Category;

        /// <summary>
        /// Gets dictionary to take account of all the items registered.
        /// </summary>
        internal static Dictionary<Item, ItemAPI> Items { get; } = new();

        /// <summary>
        /// Gets the <see cref="Item"/> belonging to the id, if any.
        /// </summary>
        /// <param name="id">The id of the item.</param>
        /// <returns>A <see cref="Item"/> or <see langword="null"/> if not found.</returns>
        public static Item Get(byte id) => List.FirstOrDefault(x => x.Base.id == id);

        /// <summary>
        /// Gets the <see cref="Item"/> belonging to the BaseItem, if any.
        /// </summary>
        /// <param name="item">The Base Item.</param>
        /// <returns>A <see cref="Item"/> or <see langword="null"/> if not found.</returns>
        public static Item Get(ItemAPI item) => List.FirstOrDefault(x => x.Base == item);
    }
}