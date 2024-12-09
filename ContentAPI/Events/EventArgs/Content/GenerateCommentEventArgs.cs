namespace ContentAPI.Events.EventArgs.Content
{
    using System.Collections.Generic;

    /// <summary>
    /// Event args when the content is getting comments.
    /// </summary>
    public class GenerateCommentEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCommentEventArgs"/> class.
        /// </summary>
        /// <param name="comments">The comments given to the content.</param>
        public GenerateCommentEventArgs(List<Comment> comments)
        {
            Comments = comments;
        }

        /// <summary>
        /// Gets or sets the score given to the Content.
        /// </summary>
        public List<Comment> Comments { get; set; }
    }
}