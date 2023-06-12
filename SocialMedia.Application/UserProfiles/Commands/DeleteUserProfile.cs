namespace SocialMedia.Application.UserProfiles.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MediatR;

    /// <summary>
    /// Delete User Profile Command
    /// </summary>
    public class DeleteUserProfile : IRequest<Unit>
    {
        /// <summary>
        /// Gets or sets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; set; }
    }
}
