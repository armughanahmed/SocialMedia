namespace SocialMedia.Domain.Aggregates.PostAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// PostComment is a class for interactions made on a Post
    /// </summary>
    public class PostInteraction
    {
        /// <summary>
        /// Gets Interaction Id
        /// </summary>
        public Guid InteractionId { get; private set; }

        /// <summary>
        /// Gets Post Id
        /// </summary>
        public Guid PostId { get; private set; }

        /// <summary>
        /// Gets Interaction Type
        /// </summary>
        public InteractionType InteractionType { get; private set; }

        /// <summary>
        /// Factory Method for creating a Post Comment
        /// </summary>
        /// <param name="postId">Post Id</param>
        /// <param name="interactionType">Interaction Type</param>
        /// <returns>Post Interaction <see cref="PostInteraction"/></returns>
        public static PostInteraction CreatePostInteraction(Guid postId, InteractionType interactionType)
        {
            // TO DO: add Validation, error handling strategies, error notification strategies.
            return new PostInteraction
            {
                PostId = postId,
                InteractionType = interactionType,
            };
        }
    }
}
