namespace Infraestructure.Interface
{
    public interface IEmployeeGet
    {
        public Task<List<Models.Employee.Employee>> GetAll();
        public Task<Models.Employee.Employee> GetById(int employeeId);
    }
}
