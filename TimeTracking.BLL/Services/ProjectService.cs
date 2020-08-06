using GenericRepository;
using TimeTracking.BLL.DTO;
using TimeTracking.Domain.Entities;


namespace TimeTracking.BLL.Services
{
    public class ProjectService : GenericService<Project, ProjectDTO, int>
    {
        public ProjectService(IGenericRepository<Project, int> repository) : base(repository)
        {
        }
    }
}
