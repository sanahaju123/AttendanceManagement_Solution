using AttendanceManagement.Models;
using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AttendanceManagementApp.Controllers
{
    public class AttendanceController : ApiController
    {
        private readonly IAttendanceService _service;
        public AttendanceController(IAttendanceService service)
        {
            _service = service;
        }
        public AttendanceController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Attendance/CreateAttendance")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateAttendance([FromBody] Attendance model)
        {
            var leaveExists = await _service.GetAttendanceById(model.Id);
            var result = await _service.CreateAttendance(model);
            return Ok(new Response { Status = "Success", Message = "Attendance created successfully!" });
        }


        [HttpPut]
        [Route("api/Attendance/UpdateAttendance")]
        public async Task<IHttpActionResult> UpdateAttendance([FromBody] Attendance model)
        {
            var result = await _service.UpdateAttendance(model);
            return Ok(new Response { Status = "Success", Message = "Attendance updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Attendance/DeleteAttendance")]
        public async Task<IHttpActionResult> DeleteAttendance(long id)
        {
            var result = await _service.DeleteAttendanceById(id);
            return Ok(new Response { Status = "Success", Message = "Attendance deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Attendance/GetAttendanceById")]
        public async Task<IHttpActionResult> GetAttendanceById(long id)
        {
            var expense = await _service.GetAttendanceById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Attendance/GetAllAttendances")]
        public async Task<IEnumerable<Attendance>> GetAllAttendances()
        {
            return _service.GetAllAttendances();
        }
    }
}
