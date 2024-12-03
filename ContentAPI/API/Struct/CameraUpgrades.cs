namespace ContentAPI.API.Struct
{
    /// <summary>
    /// Wrapper for CameraUpgrades as upgrade and not items.
    /// </summary>
    public struct CameraUpgrades
    {
        /// <summary>
        /// Upgrade Id.
        /// </summary>
        public byte ID;

        /// <summary>
        /// The type of upgrade.
        /// </summary>
        public CameraUpgradeItem.CameraUpgradeType Upgrade;

        /// <summary>
        /// The Basic Item.
        /// </summary>
        public Item Item;

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraUpgrades"/> struct.
        /// </summary>
        /// <param name="item">The <see cref="CameraUpgradeItem"/> to wrap.</param>
        public CameraUpgrades(CameraUpgradeItem item)
        {
            ID = item.upgradeId;
            Upgrade = item.UpgradeType;
            Item = item;
        }
    }
}