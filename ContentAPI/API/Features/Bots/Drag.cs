namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class Drag : Bot, IWrapper<Bot_Drag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drag"/> class.
        /// </summary>
        /// <param name="drag">The drag to wrap.</param>
        public Drag(Bot_Drag drag)
            : base(drag.bot)
        {
            Base = drag;
        }

        /// <inheritdoc/>
        public new Bot_Drag Base { get; }
    }
}