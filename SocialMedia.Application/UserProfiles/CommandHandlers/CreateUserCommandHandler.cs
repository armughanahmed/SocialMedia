namespace SocialMedia.Application.UserProfiles.CommandHandlers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using SocialMedia.Application.UserProfile.Commands;
    using SocialMedia.Dal;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Create User Command Handler
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserProfile>
    {
        /// <summary>
        /// SocialMedia Db Context
        /// </summary>
        private readonly SocialMediaContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserCommandHandler"/> class.
        /// </summary>
        /// <param name="dbContext">SocialMedia Database Context</param>
        public CreateUserCommandHandler(SocialMediaContext dbContext) => _dbContext = dbContext;

        /// <inheritdoc/>
        public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.EmailAddress, request.Phone, request.DateOfBirth, request.CurrentCity);

            var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);

            await _dbContext.UserProfiles.AddAsync(userProfile);

            await _dbContext.SaveChangesAsync();

            return userProfile;
        }
    }
}
