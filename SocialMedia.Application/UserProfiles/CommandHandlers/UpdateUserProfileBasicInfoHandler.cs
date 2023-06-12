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
    public class UpdateUserProfileBasicInfoHandler : IRequestHandler<UpdateUserProfileBasicInfo, Unit>
    {
        /// <summary>
        /// SocialMedia Db Context
        /// </summary>
        private readonly SocialMediaContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserProfileBasicInfoHandler"/> class.
        /// </summary>
        /// <param name="dbContext">SocialMedia Database Context</param>
        public UpdateUserProfileBasicInfoHandler(SocialMediaContext dbContext) => _dbContext = dbContext;

        /// <inheritdoc/>
        public async Task<Unit> Handle(UpdateUserProfileBasicInfo request, CancellationToken cancellationToken)
        {
            var userProfile = await _dbContext.UserProfiles.FirstOrDefaultAsync(x => x.UserProfileId == request.UserProfileId);

            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            if(userProfile != null)
            {
                userProfile.UpdateBasicInfo(basicInfo);

                _dbContext.UserProfiles.Update(userProfile);
                await _dbContext.SaveChangesAsync();
            }

            return default(Unit);
        }
    }
}
