using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApiJwt.Model;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult _defaultControllerCreateToken()
        {
            return Ok(new CreateToken().TokenCreate());
        }



        //[Authorize]
        //[Authorize(AuthenticationSchemes = "Bearer")]
        //[HttpGet("[action]")]
        //public IActionResult Test2()
        //{
        //    return Ok("Hoşgeldiniz");
        //}



        [HttpGet("[action]")]
        public IActionResult _defaultControllerCreateTokenForAdmin()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }


        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult AdminLogin()
        {
            return Ok("Token Başarılı Bir Şekilde Giriş Yaptı");
        }
    }
}
