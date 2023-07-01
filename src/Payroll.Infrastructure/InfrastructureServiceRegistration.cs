using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Payroll.Application.Contracts.Infrastructure;
using Payroll.Domain;
using Payroll.Infrastructure.ExternalServices;

namespace Payroll.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeService<EmployeeDTO>, EmployeeApiService>();

            return services;
        }
    }
}
