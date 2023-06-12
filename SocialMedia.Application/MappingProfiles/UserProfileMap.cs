namespace SocialMedia.Application.MappingProfiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AutoMapper;
    using SocialMedia.Application.UserProfile.Commands;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// User Profile Mapper
    /// </summary>
    public class UserProfileMap : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileMap"/> class.
        /// </summary>
        public UserProfileMap()
        {
            CreateMap<CreateUserCommand, BasicInfo>();
        }
    }
}
