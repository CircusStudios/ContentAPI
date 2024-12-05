namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using System.Linq;
    using ContentAPI.API.Struct;
    using Zorro.Core;

    using ItemAPI = global::Item;

    /// <summary>
    /// Wrapper for the Camera Item.
    /// </summary>
    public class Camera : Item
    {
        private static List<CameraUpgrades> upgrades = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Camera"/> class.
        /// Camera Item.
        /// </summary>
        /// <param name="item">item.</param>
        public Camera(ItemAPI item)
            : base(item)
        {
        }

        /// <summary>
        /// Gets instance of the Database containing all the CameraUpgrades.
        /// </summary>
        public static CameraUpgradesDatabase Instance { get; } = SingletonAsset<CameraUpgradesDatabase>.Instance;

        /// <summary>
        /// Gets all the upgrades available for the camera.
        /// </summary>
        public static List<CameraUpgrades> AllUpgrades
        {
            get
            {
                if (upgrades.Count <= 0)
                {
                    foreach (CameraUpgradeItem upgrade in Instance.Objects.ToList())
                        upgrades.Add(new(upgrade));
                }

                return upgrades;
            }
        }
    }
}