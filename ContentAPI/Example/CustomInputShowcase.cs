namespace ContentAPI.Example
{
    using ContentAPI.API.Features;
    using UnityEngine;

    /// <summary>
    /// KeyBind Showcase.
    /// </summary>
    public class CustomInputShowcase : CustomInput
    {
        /// <inheritdoc/>
        public override KeyCode Key { get; set; } = KeyCode.Backspace;

        /// <inheritdoc/>
        public override void ProcessInput()
        {
            Debug.Log("YOOO! The player clicked Backspace.");
        }
    }
}