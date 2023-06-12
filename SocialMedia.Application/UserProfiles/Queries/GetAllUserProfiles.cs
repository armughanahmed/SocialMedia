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
    /// Get All User Profiles Query
    /// </summary>
    public class GetAllUserProfiles : IRequest<IEnumerable<UserProfile>>
    {
    }
}
