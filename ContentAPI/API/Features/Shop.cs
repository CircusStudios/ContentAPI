namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using ContentAPI.API.Enums;
    using ContentAPI.API.Interface;

    /// <summary>
    /// Shop Wrapper.
    /// </summary>
    public class Shop : IWrapper<ShopHandler>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shop"/> class.
        /// </summary>
        /// <param name="shopHandler">Game ShopHandler.</param>
        internal Shop(ShopHandler shopHandler)
        {
            Base = shopHandler;
            Instance = this;
        }

        /// <summary>
        /// Gets the instance of the current shop.
        /// </summary>
        public static Shop Instance { get; private set; }

        /// <summary>
        /// Gets items present inside the shop.
        /// </summary>
        public List<ShopItem> Items
        {
            get => Base.m_ItemsForSaleDictionary.Values.ToList();
        }

        /// <summary>
        /// Gets all the items in the cart.
        /// </summary>
        public List<ShopItem> ItemsInCart
        {
            get => Base.GetItemsInCart();
        }

        /// <summary>
        /// Gets the Cart Value.
        /// </summary>
        public float CartValue => Base.GetCurrentCartValue();

        /// <summary>
        /// Gets amount of items in the cart.
        /// </summary>
        public float AmountOfItems => Base.GetNumberOfItemsInCart();

        /// <inheritdoc/>
        public ShopHandler Base { get; private set; }

        /// <summary>
        /// Gets the shopping cart.
        /// </summary>
        public ShoppingCart ShoppingCart => Base.m_ShoppingCart;

        /// <summary>
        /// Buys everything inside the shopping cart.
        /// </summary>
        public void Buy() => Base.BuyItem(Base.m_ShoppingCart);

        /// <summary>
        /// Spawns the drone.
        /// </summary>
        public void SpawnDrone() => Base.RPCA_SpawnDrone([]);

        /// <summary>
        /// Spawns a drone with items inside.
        /// </summary>
        /// <param name="items">Items with the drone.</param>
        public void SpawnDrone(List<ItemType> items) => Base.RPCA_SpawnDrone(items.Select(item => (byte)item).ToArray());

        /// <summary>
        /// Adds an item to the shopping cart.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void AddItem(ShopItem item) => ShoppingCart.AddItemToCart(item);

        /// <summary>
        /// Adds an item to the shopping cart.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void AddItem(ItemType item) => Base.RPCA_AddItemToCart((byte)item);

        /// <summary>
        /// Clears the cart.
        /// </summary>
        public void ClearCart() => ShoppingCart.ClearCart();

        /// <summary>
        /// Makes the order.
        /// </summary>
        public void Order() => Base.OnOrderCartClicked();
    }
}