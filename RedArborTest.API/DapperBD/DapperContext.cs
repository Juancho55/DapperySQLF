using DapperBD.Interface;
using Microsoft.Extensions.Configuration;

namespace DapperBD
{
    public class DapperContext : DapperConectionContext, IDapperContext
    {
        public DapperContext(IConfiguration configuration, string database) : base(configuration, database)
        {

        }
    }
}
