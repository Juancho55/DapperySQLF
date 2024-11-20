namespace Services.Services.Employee
{
    public interface IEmployeeService
    {
        public Task<bool> SaveAsync(Models.Employee.Employee request);
        public Task<bool> UpdateAsync(int employeeId, Models.Employee.Employee request);
        public Task<bool> DeleteAsync(int employeeId);
        public Task<List<Models.Employee.Employee>> GetAllAsync();
        public Task<Models.Employee.Employee> GetByIdAsync(int employeeId);        
    }
}
