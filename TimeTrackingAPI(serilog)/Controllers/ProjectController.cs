using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using TimeTracking.BLL.DTO;
using TimeTracking.BLL.Services;
using Project = TimeTracking.Domain.Entities.Project;

namespace TimeTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IGenericService<ProjectDTO, int> _service;

        public ProjectController(IGenericService<ProjectDTO, int> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Project> Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            return Ok(_service.Get(id));
        }
        [HttpPost]
        public ActionResult<Project> Add([FromBody]ProjectDTO project)
        {
            try
            {
                return Ok(_service.Add(project));
            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                return Redirect("/error");
            }
            
        }
        [HttpDelete("{id}")]
        public ActionResult<Project> Del(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch(Exception e)
            {
                Log.Error(e.ToString());
                return Redirect("/error");
            }            
        }
        [HttpPut]
        public ActionResult<Project> Update([FromBody]ProjectDTO project)
        {
            try
            {
                return Ok(_service.Update(project));
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return Redirect("/error");
            }            
        }
    }
}