namespace ContentAPI.API.Features
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Input base class.
    /// </summary>
    public abstract class Input
    {
        /// <summary>
        /// Gets the list of current Item Managers.
        /// </summary>
        public static HashSet<Input> Registered { get; } = new();

        /// <summary>
        /// Gets or sets the button to press.
        /// </summary>
        public abstract KeyCode Key { get; set; }

        /// <summary>
        /// Process the inputs.
        /// </summary>
        public abstract void ProcessInput();

        /// <summary>
        /// Registers the input.
        /// </summary>
        public void Register()
        {
            if (!Registered.Contains(this))
                Registered.Add(this);
        }

        /// <summary>
        /// Unregisters the input.
        /// </summary>
        public void UnRegister() => Registered.Remove(this);
    }
}