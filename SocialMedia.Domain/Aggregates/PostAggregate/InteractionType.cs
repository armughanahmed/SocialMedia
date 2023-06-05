namespace SocialMedia.Domain.Aggregates.PostAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interaction Type is an Enum that defines the types of interactions on a Post
    /// </summary>
    public enum InteractionType
    {
        /// <summary>
        /// Like
        /// </summary>
        Like,

        /// <summary>
        /// Dislike
        /// </summary>
        Dislike,

        /// <summary>
        /// Haha
        /// </summary>
        Haha,

        /// <summary>
        /// Wow
        /// </summary>
        Wow,

        /// <summary>
        /// Love
        /// </summary>
        Love,

        /// <summary>
        /// Angry
        /// </summary>
        Angry,
    }
}
