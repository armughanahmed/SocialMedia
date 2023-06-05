namespace SocialMedia.Domain.Aggregates.UserProfileAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// UserProfile is an aggregate for User Information
    /// </summary>
    public class UserProfile
    {
        private UserProfile()
        {
        }

        /// <summary>
        /// Gets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; private set; }

        /// <summary>
        /// Gets Identity Id
        /// </summary>
        public string IdentityId { get; private set; } = string.Empty;

        /// <summary>
        /// Gets Basic Info
        /// </summary>
        public BasicInfo? BasicInfo { get; private set; }

        /// <summary>
        /// Gets Created Date
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Gets Last Modified Date
        /// </summary>
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// Factory Method for creating a User Profile
        /// </summary>
        /// <param name="identityId">User Identity Id</param>
        /// <param name="basicInfo">User Basic Information</param>
        /// <returns>User Profile <see cref="UserProfile"/></returns>
        public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
        {
            // TO DO: add Validation, error handling strategies, error notification strategies.
            return new UserProfile
            {
                BasicInfo = basicInfo,
                IdentityId = identityId,
                CreatedDate = DateTime.UtcNow,
            };
        }

        /// <summary>
        /// Updates Basic Information Of User
        /// </summary>
        /// <param name="newInfo">New Basic Information Of User</param>
        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
