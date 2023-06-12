namespace SocialMedia.Domain.Aggregates.UserProfileAggregate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// BasicInfo is a record that contains basic information about the user
    /// </summary>
    public class BasicInfo
    {
        private BasicInfo()
        {
        }

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

        /// <summary>
        /// Factory Method for creating a Basic User Information
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="emailAddress">Email Address</param>
        /// <param name="phone">Phone</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="currentCity">Current City</param>
        /// <returns>Basic Information <see cref="BasicInfo"/></returns>
        public static BasicInfo CreateBasicInfo(string firstName, string lastName, string emailAddress, string phone, DateTime? dateOfBirth, string currentCity)
        {
            // TO DO: add Validation, error handling strategies, error notification strategies.
            return new BasicInfo
            {
                CurrentCity = currentCity,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                EmailAddress = emailAddress,
                Phone = phone,
            };
        }
    }
}
