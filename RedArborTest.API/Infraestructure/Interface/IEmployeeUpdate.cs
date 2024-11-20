namespace Infraestructure.Interface
{
    public interface IEmployeeUpdate
    {
        public Task<bool> Update(int employeeId, Models.Employee.Employee model);
    }
}
