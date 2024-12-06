namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class ToolkitBoy : Bot, IWrapper<Bot_ToolkitBoy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolkitBoy"/> class.
        /// </summary>
        /// <param name="gameObject">The <see cref="UnityEngine.GameObject"/> of the Bot.</param>
        public ToolkitBoy(GameObject gameObject)
            : base(gameObject)
        {
            if (!gameObject.TryGetComponent(out global::Bot_ToolkitBoy bot))
                throw new ArgumentException("Could not find Bot_ToolkitBoy component in GameObject");

            Base = bot;
        }

        /// <inheritdoc/>
        public new Bot_ToolkitBoy Base { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the AI is Charging.
        /// </summary>
        public bool IsCharging
        {
            get => Base.isCharging;
            set => Base.SetCharging(value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether who is the Bot targetting.
        /// </summary>
        public Player PlayerToBonk
        {
            get => Player.Get(Base.player);
            set => Base.player = value.Base;
        }

        /// <summary>
        /// Makes the AI force BONK!!.
        /// </summary>
        public void ForceBonk() => Base.RPCA_BonkTool();
    }
}