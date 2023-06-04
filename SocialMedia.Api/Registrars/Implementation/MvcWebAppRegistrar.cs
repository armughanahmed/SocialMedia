namespace SocialMedia.Api.Registrars.Implementation
{
    using Microsoft.AspNetCore.Mvc.ApiExplorer;
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
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.ApiVersion.ToString());
                }
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
