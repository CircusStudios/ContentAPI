namespace ContentAPI.API.Interface
{
    using UnityEngine;

    /// <summary>
    /// Represents an object with a <see cref="Vector3"/> position and a <see cref="Quaternion"/> rotation.
    /// </summary>
    public interface IWorldSpace
    {
        /// <summary>
        /// Gets the position of this object.
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// Gets the rotation of this object.
        /// </summary>
        public Quaternion Rotation { get; }
    }
}