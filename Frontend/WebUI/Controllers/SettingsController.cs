using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using WebUI.Models.Setting;

namespace WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name); //User → Şu an oturum açmış kullanıcıyı temsil eder.
                                                                               //Identity → Kimlik bilgilerini içerir.
                                                                               //Name → Kullanıcının kullanıcı adını(UserName) getirir.

            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = user.Name;
            userEditViewModel.Surname = user.Surname;
            userEditViewModel.Username = user.UserName;
            userEditViewModel.Email = user.Email;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            if (userEditViewModel.Password == userEditViewModel.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = userEditViewModel.Name;
                user.Surname = userEditViewModel.Surname;
                user.Email = userEditViewModel.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
