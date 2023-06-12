namespace SocialMedia.Application.UserProfile.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MediatR;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Command for Creating User
    /// </summary>
    public class CreateUserCommand : IRequest<UserProfile>
    {
        /// <summary>
        /// Gets First Name
        /// </summary>
        public string FirstName { get; private set; } = string.Empty;

        /// <summary>
        /// Gets LastName
        /// </summary>
        public string LastName { get; private set; } = string.Empty;

        /// <summary>
        /// Gets Email Address
        /// </summary>
        public string EmailAddress { get; private set; } = string.Empty;

        /// <summary>
        /// Gets Phone
        /// </summary>
        public string Phone { get; private set; } = string.Empty;

        /// <summary>
        /// Gets Date Of Birth
        /// </summary>
        public DateTime? DateOfBirth { get; private set; }

        /// <summary>
        /// Gets Current City
        /// </summary>
        public string CurrentCity { get; private set; } = string.Empty;
    }
}
