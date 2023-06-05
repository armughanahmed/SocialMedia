namespace SocialMedia.Domain.Aggregates.PostAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualBasic;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// UserProfile is an aggregate for Social Media Posts
    /// </summary>
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();

        private Post()
        {
        }

        /// <summary>
        /// Gets Post Id
        /// </summary>
        public Guid PostId { get; private set; }

        /// <summary>
        /// Gets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; private set; }

        /// <summary>
        /// Gets User Profile
        /// </summary>
        public UserProfile? UserProfile { get; private set; }

        /// <summary>
        /// Gets Text Content Of Post
        /// </summary>
        public string TextContent { get; private set; } = string.Empty;

        /// <summary>
        /// Gets Created Date
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Gets Last Modified Date
        /// </summary>
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// Gets Comments of Post
        /// </summary>
        public IEnumerable<PostComment> Comments
        {
            get { return _comments; }
        }

        /// <summary>
        /// Gets Interactions made on Post
        /// </summary>
        public IEnumerable<PostInteraction> Interactions
        {
            get { return _interactions; }
        }

        /// <summary>
        /// Factory Method for creating a Basic User Information
        /// </summary>
        /// <param name="userProfileId">User Profile Guid</param>
        /// <param name="textContent">Post's text content</param>
        /// <returns>Post <see cref="Post"/></returns>
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            // TO DO: add Validation, error handling strategies, error notification strategies.
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
            };
        }

        /// <summary>
        /// Updates Post's Text
        /// </summary>
        /// <param name="newText">Updated Post's Text</param>
        public void UpdatePostText(string newText)
        {
            TextContent = newText;
            LastModifiedDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Add Post Comment
        /// </summary>
        /// <param name="postComment">Post comment to be added</param>
        public void AddPostComment(PostComment postComment)
        {
            _comments.Add(postComment);
        }

        /// <summary>
        /// Remove Post Comment
        /// </summary>
        /// <param name="toRemovePostComment">Post comment to be removed</param>
        public void RemovePostComment(PostComment toRemovePostComment)
        {
            _comments.Remove(toRemovePostComment);
        }

        /// <summary>
        /// Add Post Interaction
        /// </summary>
        /// <param name="postInteraction">Add Post Interaction to be added</param>
        public void AddPostInteraction(PostInteraction postInteraction)
        {
            _interactions.Add(postInteraction);
        }

        /// <summary>
        /// Remove Post Interaction
        /// </summary>
        /// <param name="toRemovePostInteraction">Post interaction to be removed</param>
        public void RemovePostInteraction(PostInteraction toRemovePostInteraction)
        {
            _interactions.Remove(toRemovePostInteraction);
        }
    }
}
