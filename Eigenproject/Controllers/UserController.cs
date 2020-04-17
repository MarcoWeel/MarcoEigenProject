using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using Eigenproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eigenproject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterUser(UserModel user)
        {
            if (ModelState.IsValid)
            {
                UserProcessor.CreateUser(
                    user.Email,
                    user.DateOfBirth,
                    user.Password,
                    user.UserName
                );
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}