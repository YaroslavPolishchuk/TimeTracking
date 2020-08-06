using GenericRepository;
using TimeTracking.BLL.DTO;
using TimeTracking.Domain.Entities;

namespace TimeTracking.BLL.Services
{
    public class EmployeeService : GenericService<Employee, EmployeeDTO, int>
    {
        public EmployeeService(IGenericRepository<Employee, int> repository) : base(repository)
        {
        }
    }
}
