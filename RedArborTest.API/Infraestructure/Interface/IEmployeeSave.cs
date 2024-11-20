namespace Infraestructure.Interface
{
    public interface IEmployeeSave
    {
        public Task<bool> Save(Models.Employee.Employee model);
    }
}
