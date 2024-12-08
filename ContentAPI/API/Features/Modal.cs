namespace ContentAPI.API.Features
{
    using System.Collections.Generic;

    /// <summary>
    /// Modal wrapper base class.
    /// </summary>
    public abstract class Modal
    {
        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public abstract string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public abstract string Body { get; set; }

        /// <summary>
        /// Gets or sets a list of options.
        /// </summary>
        public abstract List<ModalOption> Options { get; set; }

        /// <summary>
        /// Shows the modal.
        /// </summary>
        public void Show()
        {
            if (Options.Count == 0)
            {
                ContentPlugin.Log.LogInfo("No options present going in safe mode.");
                global::Modal.ShowError(Title, Body);
                return;
            }

            global::Modal.Show(title: Title, body: Body, options: Options.ToArray(), () => OnClosed());
        }

        /// <summary>
        /// Called when the Modal is closed.
        /// </summary>
        /// <remarks>This gets called everytime when a player clicks a button.</remarks>
        protected virtual void OnClosed()
        {
        }

        /// <summary>
        /// Called when a button is pressed.
        /// </summary>
        /// <param name="buttonNumber">The number of the button inside the list.</param>
        protected virtual void HandleButtonClick(int buttonNumber)
        {
        }
    }
}