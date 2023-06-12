namespace SocialMedia.Api.MappingProfiles
{
    using AutoMapper;
    using SocialMedia.Api.Contracts.UserProfile.Requests;
    using SocialMedia.Api.Contracts.UserProfile.Responses;
    using SocialMedia.Application.UserProfile.Commands;
    using SocialMedia.Application.UserProfiles.Commands;
    using SocialMedia.Domain.Aggregates.UserProfileAggregate;

    /// <summary>
    /// User Profile Mapping
    /// </summary>
    public class UserProfileMappings : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileMappings"/> class.
        /// </summary>
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateUpdate, CreateUserCommand>();
            CreateMap<UserProfile, UserProfileResponse>();
            CreateMap<BasicInfo, BasicInformation>();
            CreateMap<UserProfileCreateUpdate, UpdateUserProfileBasicInfo>();
        }
    }
}
