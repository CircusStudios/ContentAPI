namespace ContentAPI.Example
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Showcase how a modal works.
    /// </summary>
    public class ModalShowcase : API.Features.Modal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalShowcase"/> class.
        /// </summary>
        public ModalShowcase()
        {
            Options.Add(new("No Cookie", () => HandleButtonClick(1)));
            Options.Add(new("Cookie!!", () => HandleButtonClick(2)));
        }

        /// <inheritdoc/>
        public override string Title { get; set; } = "Do you want a cookie?";

        /// <inheritdoc/>
        public override string Body { get; set; } = "Click 'Cookie!!' for a special cookie.";

        /// <inheritdoc/>
        public override List<ModalOption> Options { get; set; } = new();

        /// <inheritdoc/>
        protected override void OnClosed()
        {
            Debug.Log("Cookie closed.");
            base.OnClosed();
        }

        /// <inheritdoc/>
        protected override void HandleButtonClick(int buttonNumber)
        {
            if (buttonNumber == 1)
                Debug.Log("No cookie :(");
            else if (buttonNumber == 2)
                Debug.Log("Cookie :)");
            else if (buttonNumber == 3)
                Debug.Log("Wut bugged cookie??????");

            base.HandleButtonClick(buttonNumber);
        }
    }
}