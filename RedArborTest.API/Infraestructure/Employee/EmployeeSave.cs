using EntityFreamworkBD;
using EntityFreamworkBD.Models;
using Infraestructure.Interface;
using Models.Employee;

namespace Infraestructure.Employee
{
    public class EmployeeSave : IEmployeeSave
    {
        private readonly RedarborContext _employeeContext;

        public EmployeeSave(RedarborContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public async Task<bool> Save(Models.Employee.Employee model)
        {
            try
            {
                model.StatusId = Constant.Ative;
                EntityFreamworkBD.Models.Employee employee = new EntityFreamworkBD.Models.Employee()
                {
                    CompanyId = model.CompanyId,
                    CreateOn = model.CreateOn,
                    DeleteOn = model.DeleteOn,
                    Email = model.Email,
                    Fax = model.FAX,
                    LastLogin = model.LastLogin,
                    Name = model.Name,
                    Passwrod = model.Passwrod,
                    PortalId = model.PortalId,
                    RoleId = model.RoleId,
                    StatusId = model.StatusId,
                    Telephone = model.Telephone,
                    UpdateOn = model.UpdateOn,
                    UserName = model.UserName
                };
                await _employeeContext.Employees.AddAsync(employee);
                return await _employeeContext.SaveChangesAsync() > 0;
            }
            catch(Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
