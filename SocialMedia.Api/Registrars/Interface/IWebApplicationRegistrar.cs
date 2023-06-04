namespace SocialMedia.Api.Registrars.Interface
{
    /// <summary>
    /// Registers Middlewares in Application
    /// </summary>
    public interface IWebApplicationRegistrar : IRegistrar
    {
        /// <summary>
        /// Register Middlewares and Pipelines
        /// </summary>
        /// <param name="app"><see cref="WebApplication"/></param>
        public void RegisterPipelineComponents(WebApplication app);
    }
}
