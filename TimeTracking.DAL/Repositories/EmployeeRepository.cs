using GenericRepository;
using Microsoft.EntityFrameworkCore;
using TimeTracking.Domain.Entities;

namespace TimeTracking.DAL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}
