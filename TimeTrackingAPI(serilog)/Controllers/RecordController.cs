using Microsoft.AspNetCore.Mvc;
using TimeTracking.BLL.DTO;
using TimeTracking.BLL.Services;
using TimeTracking.Domain.Entities;

namespace TimeTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IGenericService<TrackRecordDTO, int> _service;
        public RecordController(IGenericService<TrackRecordDTO, int> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<TrackRecord> Get()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<TrackRecord> Get(int id)
        {
            return Ok(_service.Get(id));
        }
        [HttpPost]
        public ActionResult<TrackRecord> Add([FromBody]TrackRecordDTO model)
        {
            model.WeekNumber = model.WeekNumber;
            return Ok(_service.Add(model));
        }
        [HttpDelete("{id}")]
        public ActionResult<TrackRecord> Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
    }
}