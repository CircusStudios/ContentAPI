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
        public override KeyCode Key { get; set; } = KeyCode.F2;

        /// <inheritdoc/>
        public override void ProcessInput()
        {
            Debug.Log("YOOO! The player clicked F2.");
            API.Features.Player.LocalPlayer?.Ragdoll(5);
        }
    }
}