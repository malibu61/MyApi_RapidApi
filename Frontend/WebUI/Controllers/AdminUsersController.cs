﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AdminUsersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values= _userManager.Users.ToList();

            return View(values);
        }
    }
}
