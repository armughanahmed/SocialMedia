namespace SocialMedia.Api.Registrars.Implementation
{
    using SocialMedia.Api.Registrars.Interface;
    using SocialMedia.Application.UserProfiles.Queries;

    /// <summary>
    /// Register Services Made by Bogard (AutoMapper, MediatR)
    /// </summary>
    public class BogardRegistrar : IWebApplicationBuilderRegistrar
    {
        /// <inheritdoc/>
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllUserProfiles));
            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<GetAllUserProfiles>();
            });
        }
    }
}
