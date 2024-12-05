namespace ContentAPI.API.Features
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using ContentAPI.API.Enums;

    /// <summary>
    /// Wrapper for the contents.
    /// </summary>
    // TODO: Comments
    public class Content
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Content"/> class.
        /// </summary>
        /// <param name="content">The content Event.</param>
        public Content(ContentEvent content)
        {
            Base = content;
        }

        /// <summary>
        /// Gets basic Content.
        /// </summary>
        public ContentEvent Base { get; private set; }

        /// <summary>
        /// Gets the value of the Content.
        /// </summary>
        public float Value => Base.GetContentValue();

        /// <summary>
        /// Get the content from ContentType.
        /// </summary>
        /// <param name="contentType">The type of content.</param>
        /// <returns>The class wrapped.</returns>
        public static Content GetContent(ContentType contentType)
            => new(ContentEventIDMapper.GetContentEvent((ushort)contentType));
    }
}