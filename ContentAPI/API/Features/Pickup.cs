namespace ContentAPI.API.Features
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ContentAPI.API.Enums;
    using ContentAPI.API.Interface;
    using UnityEngine;

    using PickupAPI = global::Pickup;

    /// <summary>
    /// Wrapper for Pickups.
    /// </summary>
    public class Pickup : IWorldSpace
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pickup"/> class.
        /// </summary>
        /// <param name="item">The <see cref="global::Pickup"/> to be encapsulated.</param>
        public Pickup(PickupAPI item)
        {
            if (Get(item.m_itemID) != null)
                return;

            Items.Add(this, item);
            Base = item;
        }

        /// <summary>
        /// Gets a list of all Items Registered in the game.
        /// </summary>
        public static List<Pickup> List => Items.Keys.ToList();

        /// <summary>
        /// Gets the Base Class.
        /// </summary>
        public PickupAPI Base { get; private set; }

        /// <inheritdoc/>
        public Vector3 Position
        {
            get => Base.transform.position;
            set
            {
                Base.transform.position = value;
                Sync();
            }
        }

        /// <inheritdoc/>
        public Quaternion Rotation
        {
            get => Base.transform.rotation;
            set
            {
                Base.transform.rotation = value;
                Sync();
            }
        }

        /// <summary>
        /// Gets the Type of pickup.
        /// </summary>
        public ItemType Type => (ItemType)Base.m_itemID;

        /// <summary>
        /// Gets dictionary to take account of all the items registered.
        /// </summary>
        internal static Dictionary<Pickup, PickupAPI> Items { get; } = new();

        /// <summary>
        /// Gets the <see cref="Pickup"/> belonging to the id, if any.
        /// </summary>
        /// <param name="id">The id of the item.</param>
        /// <returns>A <see cref="Pickup"/> or <see langword="null"/> if not found.</returns>
        public static Pickup Get(byte id) => List.FirstOrDefault(x => x.Base.m_itemID == id);

        /// <summary>
        /// Create a Pickup.
        /// </summary>
        /// <param name="itemType">ItemType.</param>
        /// <param name="position">Position.</param>
        /// <param name="rotation">Rotation.</param>
        /// <returns>The newly created pickup.</returns>
        public static Pickup Create(ItemType itemType, Vector3 position, Quaternion rotation)
        {
            return new(PickupHandler.CreatePickup((byte)itemType, new(Guid.NewGuid()), position, rotation));
        }

        /// <summary>
        /// Removes the Pickup.
        /// </summary>
        /// <remarks>You need to be LobbyOwner.</remarks>
        public void Remove() => Base.RPC_Remove();

        /// <summary>
        /// Makes the Pickup Sync with the clients.
        /// </summary>
        public void Sync() => Base.ForceSync();

        /// <summary>
        /// Makes the Pickup travel via Velocity.
        /// </summary>
        /// <param name="vel">Velocity.</param>
        /// <param name="angVel">Angle Velocity.</param>
        public void SetVelocity(Vector3 vel, Vector3 angVel) => Base.RPC_SetVelocity(vel, angVel);
    }
}