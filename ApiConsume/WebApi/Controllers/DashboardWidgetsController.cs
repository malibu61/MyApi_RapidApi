using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;

        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }

        [HttpGet("GetAllStaffCount")]
        public IActionResult GetAllStaffCount()
        {
            var values = _staffService.TAllStaffCount();
            return Ok(values);
        }

        [HttpGet("GetAllBookingsCount")]
        public IActionResult GetAllBookingsCount()
        {
            var values = _bookingService.TGetAllBookingsCount();
            return Ok(values);
        }

        [HttpGet("GetAllAppUsersCount")]
        public IActionResult GetAllAppUsersCount()
        {
            var values = _appUserService.TGetAllAppUsersCount();
            return Ok(values);
        }

        [HttpGet("GetAllRoomsCount")]
        public IActionResult GetAllRoomsCount()
        {
            var values = _roomService.TGettAllRoomsCount();
            return Ok(values);
        }



    }
}
