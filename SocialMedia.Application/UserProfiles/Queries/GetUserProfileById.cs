namespace SocialMedia.Application.UserProfiles.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MediatR;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Get User Profile By Id Query
    /// </summary>
    public class GetUserProfileById : IRequest<UserProfile>
    {
        /// <summary>
        /// Gets or sets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; set; }
    }
}
