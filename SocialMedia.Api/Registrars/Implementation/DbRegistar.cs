namespace SocialMedia.Api.Registrars.Implementation
{
    using Microsoft.EntityFrameworkCore;
    using SocialMedia.Api.Registrars.Interface;
    using SocialMedia.Dal;

    /// <summary>
    /// Registers EF Core services
    /// </summary>
    public class DbRegistar : IWebApplicationBuilderRegistrar
    {
        /// <inheritdoc/>
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Default");

            // Registering Db Context
            builder.Services.AddDbContext<SocialMediaContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
