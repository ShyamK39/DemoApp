using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserInfoRepo _userInfoRepo;


        public HomeController(IUserInfoRepo userInfoRepo)
        {
            _userInfoRepo = userInfoRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserInfo user)
        {
            _userInfoRepo.AddUser(user);
            TempData["Email"] = user.Email;
            return RedirectToAction("EmailVerification");
        }

        public IActionResult EmailVerification()
        {
            var users = _userInfoRepo.GetAllUsers().OrderBy(p => p.UserID);
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
