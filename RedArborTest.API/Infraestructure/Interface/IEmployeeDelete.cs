namespace Infraestructure.Interface
{
    public interface IEmployeeDelete
    {
        public Task<bool> Delete(int employeeId);
    }
}
