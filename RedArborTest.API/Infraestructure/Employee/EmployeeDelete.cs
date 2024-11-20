using EntityFreamworkBD;
using EntityFreamworkBD.Models;
using Infraestructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Employee
{
    public class EmployeeDelete : IEmployeeDelete
    {
        private readonly RedarborContext _context;

        public EmployeeDelete(RedarborContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(int employeeId)
        {
            var employeetoDelete = await _context.Employees.FindAsync((long)employeeId);

            if (employeetoDelete == null)
                return false;

            _context.Employees.Remove(employeetoDelete);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
