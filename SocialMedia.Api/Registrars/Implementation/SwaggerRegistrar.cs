using SocialMedia.Api.Options;
using SocialMedia.Api.Registrars.Interface;

namespace SocialMedia.Api.Registrars.Implementation
{
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
