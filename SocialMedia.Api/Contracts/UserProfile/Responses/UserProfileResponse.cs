namespace SocialMedia.Api.Contracts.UserProfile.Responses
{
    /// <summary>
    /// User Profile Response record contains User Profile response to be sent
    /// </summary>
    public record UserProfileResponse
    {
        /// <summary>
        /// Gets or Sets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; set; }

        /// <summary>
        /// Gets or Sets Basic Info
        /// </summary>
        public BasicInformation? BasicInfo { get; set; }

        /// <summary>
        /// Gets or Sets Created Date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets Last Modified Date
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }
    }
}
