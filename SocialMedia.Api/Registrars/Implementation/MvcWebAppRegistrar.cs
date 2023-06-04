namespace SocialMedia.Api.Registrars.Implementation
{
    using SocialMedia.Api.Registrars.Interface;

    /// <summary>
    /// Registers Middlewares and Pipelines related to Application
    /// </summary>
    public class MvcWebAppRegistrar : IWebApplicationRegistrar
    {
        /// <summary>
        /// Registers .net core MVC Pipelines
        /// </summary>
        /// <param name="app"><see cref="WebApplication"/></param>
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
