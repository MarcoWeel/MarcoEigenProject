using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;

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
                string salt = CreateHash.GenerateSalt();
                string password = CreateHash.GenerateHash(salt, user.Password);
                UserProcessor.CreateUser(
                    user.Email,
                    user.DateOfBirth,
                    password,
                    user.UserName,
                    salt
                    
                );
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginUser(LoginUserModel login)
        {
            UserDataModel userData = UserProcessor.GetUserByUserName(login.Username);
            bool isvalid = CreateHash.CheckPassword(userData.Salt, userData.Password, login.Password);
            if (isvalid)
            {
               return RedirectToAction("index", "Home");
            }
            return View();

        }
    }
}