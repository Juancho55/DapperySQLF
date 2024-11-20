using DapperBD;
using DapperBD.Interface;
using EntityFreamworkBD;
using EntityFreamworkBD.Models;
using Infraestructure.Employee;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RedarborContext>(db => db.UseSqlServer("EmployeeContext"));
            services.AddSingleton<IDapperContext, DapperContext>(db => new DapperContext(configuration, "RedarborConnectionString"));

            services.AddTransient<IEmployeeDelete, EmployeeDelete>();
            services.AddTransient<IEmployeeGet, EmployeeGet>();
            services.AddTransient<IEmployeeSave, EmployeeSave>();
            services.AddTransient<IEmployeeUpdate, EmployeeUpdate>();
        }
    }
}
