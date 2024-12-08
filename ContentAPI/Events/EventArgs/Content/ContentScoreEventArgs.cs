namespace ContentAPI.Events.EventArgs.Content
{
    /// <summary>
    /// Event args when the content is finished.
    /// </summary>
    public class ContentScoreEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentScoreEventArgs"/> class.
        /// </summary>
        /// <param name="score">The score given to the player.</param>
        public ContentScoreEventArgs(float score)
        {
            Score = score;
        }

        /// <summary>
        /// Gets or sets the score given to the Content.
        /// </summary>
        public float Score { get; set; }
    }
}