namespace SocialMedia.Application.UserProfiles.CommandHandlers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Application.UserProfile.Commands;
    using SocialMedia.Application.UserProfiles.Commands;
    using SocialMedia.Dal;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Update User Profile Handler
    /// </summary>
    public class DeleteUserProfileHandler : IRequestHandler<DeleteUserProfile, Unit>
    {
        /// <summary>
        /// SocialMedia Db Context
        /// </summary>
        private readonly SocialMediaContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserProfileHandler"/> class.
        /// </summary>
        /// <param name="dbContext">SocialMedia Database Context</param>
        public DeleteUserProfileHandler(SocialMediaContext dbContext) => _dbContext = dbContext;

        /// <inheritdoc/>
        public async Task<Unit> Handle(DeleteUserProfile request, CancellationToken cancellationToken)
        {
            var userProfile = await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);

            if(userProfile != null)
            {
                _dbContext.UserProfiles.Remove(userProfile);
                await _dbContext.SaveChangesAsync();
            }

            return default(Unit);
        }
    }
}
