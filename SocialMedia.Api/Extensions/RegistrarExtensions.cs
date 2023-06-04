namespace SocialMedia.Api.Extensions
{
    using SocialMedia.Api.Registrars.Interface;

    /// <summary>
    /// An Extension Class which serves as resitering services and middlewares
    /// </summary>
    public static class RegistrarExtensions
    {
        /// <summary>
        /// Extension Method used for Registering Services
        /// </summary>
        /// <param name="builder">web application builder <see cref="WebApplicationBuilder"/></param>
        /// <param name="scanningType">takes Type <see cref="Type"/>, used for scanning a particular assembly</param>
        public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(builder);
            }
        }

        /// <summary>
        /// Extension Method used for Registering Middleware Pipelines
        /// </summary>
        /// <param name="app">web application <see cref="WebApplication"/></param>
        /// <param name="scanningType">takes Type <see cref="Type"/>, used for scanning a particular assembly</param>
        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationRegistrar>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType)
            where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
