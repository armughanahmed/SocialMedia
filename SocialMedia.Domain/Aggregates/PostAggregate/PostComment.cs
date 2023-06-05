namespace SocialMedia.Domain.Aggregates.PostAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// PostComment is a class for comments made on a Post
    /// </summary>
    public class PostComment
    {
        private PostComment()
        {
        }

        /// <summary>
        /// Gets Comment Id
        /// </summary>
        public Guid CommentId { get; private set; }

        /// <summary>
        /// Gets Post Id
        /// </summary>
        public Guid PostId { get; private set; }

        /// <summary>
        /// Gets Text
        /// </summary>
        public string Text { get; private set; } = string.Empty;

        /// <summary>
        /// Gets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; private set; }

        /// <summary>
        /// Gets Created Date
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Gets Last Modified Date
        /// </summary>
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// Factory Method for creating a Post Comment
        /// </summary>
        /// <param name="postId">Post Id</param>
        /// <param name="text">Post Comment Text</param>
        /// <param name="userProfileId">User Profile Id</param>
        /// <returns>Post Comment <see cref="PostComment"/></returns>
        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
        {
            // TO DO: add Validation, error handling strategies, error notification strategies.
            return new PostComment
            {
                PostId = postId,
                Text = text,
                CreatedDate = DateTime.UtcNow,
            };
        }

        /// <summary>
        /// Updates Post Comment
        /// </summary>
        /// <param name="commentText">New Basic Information Of User</param>
        public void UpdatePostCommentText(string commentText)
        {
            Text = commentText;
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
