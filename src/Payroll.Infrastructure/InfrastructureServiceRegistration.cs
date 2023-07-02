using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Payroll.Application.Contracts.Infrastructure;
using Payroll.Application.Models;
using Payroll.Domain;
using Payroll.Infrastructure.ExternalServices;

namespace Payroll.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<ExternalAPISettings>(c => configuration.GetSection("EmployeeApi"));
            services.AddScoped<IEmployeeService<EmployeeDTO>, EmployeeApiService>();
            return services;
        }
    }
}
