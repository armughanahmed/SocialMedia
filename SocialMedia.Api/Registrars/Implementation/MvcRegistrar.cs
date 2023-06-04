namespace SocialMedia.Api.Registrars.Implementation
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Versioning;
    using SocialMedia.Api.Registrars.Interface;

    /// <summary>
    /// Register .net core MVC Services
    /// </summary>
    public class MvcRegistrar : IWebApplicationBuilderRegistrar
    {
        /// <summary>
        /// Register MVC Services by taking WebApplicationBuilder Object
        /// </summary>
        /// <param name="builder"><see cref="WebApplicationBuilder"/></param>
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new UrlSegmentApiVersionReader();
            });

            builder.Services.AddVersionedApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
