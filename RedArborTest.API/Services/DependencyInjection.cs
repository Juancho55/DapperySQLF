using Microsoft.Extensions.DependencyInjection;
using Services.Services.Employee;

namespace Services
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeService, EmployeeService>();
        }
    }
}
