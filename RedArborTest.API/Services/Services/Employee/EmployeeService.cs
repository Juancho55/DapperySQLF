using Infraestructure.Interface;
using System.Runtime.CompilerServices;

namespace Services.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDelete employeeDelete;
        private readonly IEmployeeSave employeeSave;
        private readonly IEmployeeUpdate employeeUpdate;
        private readonly IEmployeeGet employeeGet;

        public EmployeeService(IEmployeeDelete employeeDelete, IEmployeeSave employeeSave, IEmployeeUpdate employeeUpdate, IEmployeeGet employeeGet)
        {
            this.employeeDelete = employeeDelete;
            this.employeeSave = employeeSave;
            this.employeeUpdate = employeeUpdate;
            this.employeeGet = employeeGet;
        }

        public async Task<bool> SaveAsync(Models.Employee.Employee request)
        {
            return await employeeSave.Save(request);
        }

        public async Task<bool> UpdateAsync(int employeeId, Models.Employee.Employee request)
        {
            return await employeeUpdate.Update(employeeId, request);
        }

        public async Task<bool> DeleteAsync(int employeeId)
        {
            return await employeeDelete.Delete(employeeId);
        }

        public async Task<List<Models.Employee.Employee>> GetAllAsync()
        {
            return await employeeGet.GetAll();
        }

        public async Task<Models.Employee.Employee> GetByIdAsync(int employeeId)
        {
            return await employeeGet.GetById(employeeId);
        }
    }
}
