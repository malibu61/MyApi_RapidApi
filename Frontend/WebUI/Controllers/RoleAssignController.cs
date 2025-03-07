﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Dtos.RoleDto;

namespace WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }


        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user =await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user != null)
            {
                TempData["userid"] = user.Id;
            }

            var roles =await _roleManager.Roles.ToListAsync();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignDto> roleAssignDtos = new List<RoleAssignDto>();
            foreach (var item in roles)
            {
                RoleAssignDto model = new RoleAssignDto();
                model.RoleID = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignDtos.Add(model);
            }
            return View(roleAssignDtos);

        }


        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignDto> roleAssignDtos)
        {
            var userid = int.Parse(TempData["userid"].ToString());
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);
            foreach (var item in roleAssignDtos)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
