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
    /// Query Handler For Getting User Profile by Id
    /// </summary>
    public class GetUserProfileByIdQueryHandler : IRequestHandler<GetUserProfileById, UserProfile?>
    {
        /// <summary>
        /// SocialMedia Database Context
        /// </summary>
        private readonly SocialMediaContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserProfileByIdQueryHandler"/> class.
        /// </summary>
        /// <param name="dbContext">SocialMedia Database Context</param>
        public GetUserProfileByIdQueryHandler(SocialMediaContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <inheritdoc/>
        public async Task<UserProfile?> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            return await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);
        }
    }
}
