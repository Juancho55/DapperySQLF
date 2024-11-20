using Dapper;
using DapperBD.Interface;
using Infraestructure.Interface;
using System.Data;

namespace Infraestructure.Employee
{
    public class EmployeeGet : IEmployeeGet
    {
        private readonly IDapperContext dapperContext;

        public EmployeeGet(IDapperContext dapperContext)
        {
            this.dapperContext = dapperContext;
        }

        public async Task<List<Models.Employee.Employee>> GetAll()
        {
            string sql = @"SELECT EmployeeId, CompanyId, CreateOn, DeleteOn, Email, FAX, Name, LastLogin, Passwrod, PortalId, RoleId, StatusId, Telephone, UpdateOn, UserName
                           FROM Employee WHERE StatusId = " + Constant.Ative;
            IDbConnection db = dapperContext.GetSqlCnn();
            var employee = await db.QueryAsync<Models.Employee.Employee>(sql);
            return employee.ToList();
        }

        public async Task<Models.Employee.Employee> GetById(int employeeId)
        {
            string sql = @"SELECT EmployeeId, CompanyId, CreateOn, DeleteOn, Email, FAX, Name, LastLogin, Passwrod, PortalId, RoleId, StatusId, Telephone, UpdateOn, UserName
                           FROM Employee WHERE StatusId = " + Constant.Ative + "and EmployeeId = " + employeeId;
            IDbConnection db = dapperContext.GetSqlCnn();
            var employee = await db.QueryAsync<Models.Employee.Employee>(sql);
            return employee.FirstOrDefault();
        }
    }
}
