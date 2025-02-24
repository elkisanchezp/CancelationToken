using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ExampleCancelationToken.Application.Extensions
{
    public static class ApplicationDI
    {
        public static void AddAplication(this IServiceCollection services)
        {
            #region MediatR

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            #endregion
        }
    }
}
