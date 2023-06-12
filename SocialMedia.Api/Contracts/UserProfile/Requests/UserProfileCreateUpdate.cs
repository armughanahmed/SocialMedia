namespace SocialMedia.Api.Contracts.UserProfile.Requests
{
    /// <summary>
    /// Request For Creating / Updating User Profile
    /// </summary>
    public record UserProfileCreateUpdate
    {
        /// <summary>
        /// Gets or sets User Profile Id
        /// </summary>
        public Guid UserProfileId { get; set; }

        /// <summary>
        /// Gets or sets first Name
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets LastName
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets Email Address
        /// </summary>
        public string EmailAddress { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets Phone
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets Date Of Birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets Current City
        /// </summary>
        public string CurrentCity { get; set; } = string.Empty;
    }
}
