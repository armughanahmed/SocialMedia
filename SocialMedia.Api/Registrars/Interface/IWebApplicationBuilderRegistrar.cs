namespace SocialMedia.Api.Registrars.Interface
{
    /// <summary>
    /// Registers Web Builder Services
    /// </summary>
    public interface IWebApplicationBuilderRegistrar : IRegistrar
    {
        /// <summary>
        /// Registers Web Application Services
        /// </summary>
        /// <param name="builder"><see cref="WebApplicationBuilder"/></param>
        void RegisterServices(WebApplicationBuilder builder);
    }
}
