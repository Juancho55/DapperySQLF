using Models.Employee;
using RedArborTest.API.Models.EmployeeAPI;
using System.Linq;

namespace RedArborTest.API.ModelsAPI.Mapper
{
    public class EmployeeMap
    {
        public Employee Mapreq(EmployeeRequestModel model, int employeeId = 0)
        {
            return new Employee()
            {
                CompanyId = model.CompanyId,
                EmployeeId = employeeId,
                CreateOn = model.CreateOn.HasValue ? model.CreateOn.Value : DateTime.Now,
                DeleteOn = model.DeleteOn,
                Email = model.Email,
                FAX = model.FAX,
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
        }

        public List<EmployeeResponseModel> Mapresponse(List<Employee> model)
        {
            return model.Select(s => new EmployeeResponseModel()
            {
                CompanyId = s.CompanyId,
                EmployeeId = s.EmployeeId,
                CreateOn = s.CreateOn,
                DeleteOn = s.DeleteOn,
                Email = s.Email,
                FAX = s.FAX,
                LastLogin = s.LastLogin,
                Name = s.Name,
                Passwrod = s.Passwrod,
                PortalId = s.PortalId,
                RoleId = s.RoleId,
                StatusId = s.StatusId,
                Telephone = s.Telephone,
                UpdateOn = s.UpdateOn,
                UserName = s.UserName
            }).ToList();
        }

        public EmployeeResponseModel Mapresponse(Employee model)
        {
            if (model == null) return new EmployeeResponseModel();

            return new EmployeeResponseModel()
            {
                CompanyId = model.CompanyId,
                EmployeeId = model.EmployeeId,
                CreateOn = model.CreateOn,
                DeleteOn = model.DeleteOn,
                Email = model.Email,
                FAX = model.FAX,
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
        }
    }
}
