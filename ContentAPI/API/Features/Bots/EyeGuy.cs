namespace ContentAPI.API.Features.Bots
{
    using System;
    using ContentAPI.API.Interface;
    using UnityEngine;

    /// <summary>
    /// Wrapper for the monster.
    /// </summary>
    public class EyeGuy : Bot, IWrapper<Bot_EyeGuy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EyeGuy"/> class.
        /// </summary>
        /// <param name="eye">The eye to wrap.</param>
        public EyeGuy(Bot_EyeGuy eye)
            : base(eye.bot)
        {
            Base = eye;
        }

        /// <inheritdoc/>
        public new Bot_EyeGuy Base { get; }
    }
}