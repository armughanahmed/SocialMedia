namespace SocialMedia.Api
{
    /// <summary>
    /// Routes URL used with the in the application
    /// </summary>
    public static class ApiRoutes
    {
        /// <summary>
        /// Base Route of the SocialMedia API
        /// </summary>
        public const string BaseRoute = "api/v{version:apiVersion}/[controller]";

        /// <summary>
        /// User Profile Route of the SocialMedia API
        /// </summary>
        public static class UserProfile
        {
            /// <summary>
            /// CRUD Operations using User Id for User Profile
            /// </summary>
            public const string IdRoute = "{id}";
        }

        /// <summary>
        /// User Profile Route of the SocialMedia API
        /// </summary>
        public static class Posts
        {
            /// <summary>
            /// Getting Posts By Id Profile Route
            /// </summary>
            public const string GetById = "{id}";
        }
    }
}
