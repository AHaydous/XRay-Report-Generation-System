using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services.IServices;
using Infrastructure.DTO;
using Infrastructure.Services;

namespace XRayReportApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        [Route("GetAllAppointments")]
        public async Task<BaseResponseDTO<IEnumerable<AppointmentDto>>> GetAppointments()
        {
            return await _appointmentService.GetAppointments();
        }


        [HttpPost("AddAppointment")]
        public async Task<BaseResponseDTO<AppointmentDto>> AddAppointment([FromBody] AppointmentDto appointmentDTO)
        {
            return await _appointmentService.AddAppointment(appointmentDTO);
        }

        [HttpPut("UpdateAppointment")]
        public async Task<BaseResponseDTO<AppointmentDto>> UpdateAppointment([FromBody] AppointmentDto appointmentDTO)
        {
            return await _appointmentService.UpdateAppointment(appointmentDTO);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<BaseResponseDTO<object>> DeleteAppointment(long id)
        {
            return await _appointmentService.DeleteAppointment(id);
        }

        [HttpGet("GetAppointmentById/{id}")]
        public async Task<BaseResponseDTO<AppointmentDto>> GetAppointmentbyId(long id)
        {
            return await _appointmentService.GetAppointmentById(id);
        }
    }
}
