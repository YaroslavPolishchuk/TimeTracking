using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TimeTracking.BLL.DTO;
using TimeTracking.BLL.Services;
using TimeTrackingAPI.Models;
using TimeTrackingAPI.ViewModels;

namespace TimeTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        private readonly IGenericService<ProjectDTO, int> _projectService;
        private readonly IGenericService<ActivityTypeDTO, int> _AtService;
        private readonly IGenericService<EmployeeDTO, int> _EmployeeService;
        private readonly IGenericService<RoleDTO, int> _RoleService;
        private readonly IGenericService<TrackRecordDTO, int> _TrService;

        public TrackingController(IGenericService<ProjectDTO, int> projectService, IGenericService<ActivityTypeDTO, int> atService,
            IGenericService<EmployeeDTO, int> employeeService, IGenericService<RoleDTO, int> roleService, IGenericService<TrackRecordDTO, int> trService)
        {
            _projectService = projectService;
            _AtService = atService;
            _EmployeeService = employeeService;
            _RoleService = roleService;
            _TrService = trService;
        }

        [HttpPost]
        [Route("date")]
        public ActionResult<IEnumerable<ResultViewModel>> GetByDate([FromBody] TimeTrackingByDate model)
        {
            var viewModel = from trackRecords in _TrService.GetAll()
                            join employees in _EmployeeService.GetAll() on trackRecords.EmployeeId equals employees.EmployeeId
                            join roles in _RoleService.GetAll() on trackRecords.RoleId equals roles.RoleId
                            join activityTypes in _AtService.GetAll() on trackRecords.ActivityId equals activityTypes.ActivityId
                            join projects in _projectService.GetAll() on trackRecords.ProjectId equals projects.ProjectId
                            where trackRecords.EmployeeId == model.EmployeeId
                            where trackRecords.TrackDate == model.DateTrack
                            select new ResultViewModel
                            {
                                TrackRecordId = trackRecords.TrackRecordId,
                                TrackDate = trackRecords.TrackDate,
                                Hours = trackRecords.Hours,
                                WeekNumber = trackRecords.WeekNumber,
                                EmployeeName = employees.Name,
                                ActivityName = activityTypes.ActivityName,
                                RoleName = roles.RoleName,
                                ProjectName = projects.ProjectName
                            };
            return Ok(viewModel);
        }
        [HttpPost]
        [Route("week")]
        public ActionResult<IEnumerable<ResultViewModel>> GetByDate([FromBody] TimeTrackingByWeek model)
        {
            var viewModel = from trackRecords in _TrService.GetAll()
                            join employees in _EmployeeService.GetAll() on trackRecords.EmployeeId equals employees.EmployeeId
                            join roles in _RoleService.GetAll() on trackRecords.RoleId equals roles.RoleId
                            join activityTypes in _AtService.GetAll() on trackRecords.ActivityId equals activityTypes.ActivityId
                            join projects in _projectService.GetAll() on trackRecords.ProjectId equals projects.ProjectId
                            where trackRecords.EmployeeId == model.EmployeeId
                            where trackRecords.WeekNumber == model.WeekNumber
                            select new ResultViewModel
                            {
                                TrackRecordId = trackRecords.TrackRecordId,
                                TrackDate = trackRecords.TrackDate,
                                Hours = trackRecords.Hours,
                                WeekNumber=trackRecords.WeekNumber,
                                EmployeeName = employees.Name,
                                ActivityName = activityTypes.ActivityName,
                                RoleName = roles.RoleName,
                                ProjectName = projects.ProjectName
                            };
            return Ok(viewModel);
        }
        
    }
}