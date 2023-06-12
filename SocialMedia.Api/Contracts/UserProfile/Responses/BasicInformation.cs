namespace SocialMedia.Api.Contracts.UserProfile.Responses
{
    /// <summary>
    /// Basic Information record contains basic information about the user that needs to be sent in response contract
    /// </summary>
    public record BasicInformation
    {
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
