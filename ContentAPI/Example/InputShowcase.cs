namespace ContentAPI.Example
{
    using UnityEngine;
    using Input = ContentAPI.API.Features.Input;

    /// <summary>
    /// KeyBind Showcase.
    /// </summary>
    public class InputShowcase : Input
    {
        /// <inheritdoc/>
        public override KeyCode Key { get; set; } = KeyCode.Backspace;

        /// <inheritdoc/>
        public override void ProcessInput()
        {
            Debug.Log("The player Clicked Backspace Button.");
        }
    }
}