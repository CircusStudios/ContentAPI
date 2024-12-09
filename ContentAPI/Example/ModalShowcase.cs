namespace ContentAPI.Example
{
    using System.Collections.Generic;

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
            ContentPlugin.Log.LogInfo("Cookie closed.");
            base.OnClosed();
        }

        /// <inheritdoc/>
        protected override void HandleButtonClick(int buttonNumber)
        {
            if (buttonNumber == 1)
                ContentPlugin.Log.LogInfo("No cookie :(");
            else if (buttonNumber == 2)
                ContentPlugin.Log.LogInfo("Cookie :)");
            else if (buttonNumber == 3)
                ContentPlugin.Log.LogInfo("Wut bugged cookie??????");

            base.HandleButtonClick(buttonNumber);
        }
    }
}