using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebUI.Dtos.AppUserDto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet]
        public IActionResult UserListWithWorkLocation()
        {
            //var values = _appUserService.TAppUserListWithWorkLocation();
            var context = new Context();
            var values=context.Users.Include(x => x.WorkLocation).Select(y=>new ResultAppUserWithWorkLocationDto
            {
                Name=y.Name,
                Surname=y.Surname,
                ImageUrl=y.ImageUrl,
                City=y.City,
                WorkLocationName= y.WorkLocation.WorkLocationName,
                Gender= y.Gender,
                Country=y.Country
            });

            return Ok(values);
        }
        [HttpGet("AppUserList")]
        public IActionResult AppUserList()
        {
            var values = _appUserService.TGetList();
            return Ok(values);
        }
    }
}
