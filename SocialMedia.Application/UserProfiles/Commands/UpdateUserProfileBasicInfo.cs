namespace SocialMedia.Application.UserProfiles.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MediatR;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// Update User Profile Basic Info Command
    /// </summary>
    public class UpdateUserProfileBasicInfo : IRequest<Unit>
    {
        /// <summary>
        /// Gets or Sets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; set; }

        /// <summary>
        /// Gets or Sets First Name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets Email Address
        /// </summary>
        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets Date Of Birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Current City
        /// </summary>
        public string CurrentCity { get; set; } = string.Empty;
    }
}
