using GenericRepository;
using TimeTracking.BLL.DTO;
using TimeTracking.Domain.Entities;


namespace TimeTracking.BLL.Services
{
    public class RoleService : GenericService<Role, RoleDTO, int>
    {
        public RoleService(IGenericRepository<Role, int> repository) : base(repository)
        {
        }
    }
}
