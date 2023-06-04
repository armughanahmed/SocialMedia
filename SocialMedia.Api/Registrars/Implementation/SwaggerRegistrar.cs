namespace SocialMedia.Api.Registrars.Implementation
{
    using SocialMedia.Api.Options;
    using SocialMedia.Api.Registrars.Interface;

    /// <summary>
    /// Registers Swagger Services
    /// </summary>
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        /// <summary>
        /// Registers Swagger Services
        /// </summary>
        /// <param name="builder"><see cref="WebApplicationBuilder"/></param>
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
