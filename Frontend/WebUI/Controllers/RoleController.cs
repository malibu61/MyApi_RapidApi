using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Dtos.RoleDto;

namespace WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleDto addRoleDto)
        {
            AppRole appRole = new AppRole()
            {
                Name = addRoleDto.RoleName
            };

            var result = await _roleManager.CreateAsync(appRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            await _roleManager.DeleteAsync(values);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);

            UpdateRoleDto updateRoleDto= new UpdateRoleDto()
            {
                RoleID = values.Id,
                RoleName=values.Name
            };

            return View(updateRoleDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto updateRoleDto)
        {
            var values=_roleManager.Roles.FirstOrDefault(x=>x.Id==updateRoleDto.RoleID);

            values.Name = updateRoleDto.RoleName;

            var result = await _roleManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}
