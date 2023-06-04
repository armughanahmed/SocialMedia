namespace SocialMedia.Api.Registrars.Implementation
{
    using Microsoft.AspNetCore.Mvc.ApiExplorer;
    using SocialMedia.Api.Registrars.Interface;

    /// <summary>
    /// Registers Swagger Middlewares
    /// </summary>
    public class SwaggerWebAppRegistrar : IWebApplicationRegistrar
    {
        /// <summary>
        /// Registers Swagger middlewares
        /// </summary>
        /// <param name="app"><see cref="WebApplicationBuilder"/></param>
        public void RegisterPipelineComponents(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
                }
            });
        }
    }
}
