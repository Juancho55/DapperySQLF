using EntityFreamworkBD;
using EntityFreamworkBD.Models;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Employee
{
    public class EmployeeUpdate : IEmployeeUpdate
    {
        private readonly RedarborContext _context;

        public EmployeeUpdate(RedarborContext context)
        {
            _context = context;
        }
        public async Task<bool> Update(int employeeId, Models.Employee.Employee model)
        {
            if (employeeId != model.EmployeeId) { return false; }
            model.UpdateOn = DateTime.Now;
            EntityFreamworkBD.Models.Employee employee = new EntityFreamworkBD.Models.Employee()
            {
                CompanyId = model.CompanyId,
                EmployeeId = model.EmployeeId,
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
            _context.Entry(employee).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
