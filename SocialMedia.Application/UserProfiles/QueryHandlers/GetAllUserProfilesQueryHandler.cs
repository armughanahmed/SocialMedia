namespace SocialMedia.Application.UserProfiles.QueryHandlers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Application.UserProfiles.Queries;
    using SocialMedia.Dal;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Query Handler For Getting All User Profiles
    /// </summary>
    public class GetAllUserProfilesQueryHandler : IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
    {
        /// <summary>
        /// SocialMedia Database Context
        /// </summary>
        private readonly SocialMediaContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUserProfilesQueryHandler"/> class.
        /// </summary>
        /// <param name="dbContext">SocialMedia Database Context</param>
        public GetAllUserProfilesQueryHandler(SocialMediaContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
        {
            return await _dbContext.UserProfiles.ToListAsync();
        }
    }
}
