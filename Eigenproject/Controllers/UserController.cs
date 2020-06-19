using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Authentication;

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
                string salt = HashingLogic.GenerateSalt();
                string password = HashingLogic.GenerateHash(salt, user.Password);
                UserProcessor.CreateUser(
                    user.Email,
                    user.DateOfBirth,
                    password,
                    user.UserName,
                    salt
                    
                );
                return RedirectToAction("ViewPosts", "Post");
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
            bool isValid = HashingLogic.CheckPassword(userData.Salt, userData.Password, login.Password);
            if (isValid)
            {
                var UserClaims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, userData.UserName),
                };

                var UserIdentity = new ClaimsIdentity(UserClaims, "User Identity");
                var UserPrincipal = new ClaimsPrincipal(new[] { UserIdentity });

                HttpContext.SignInAsync(UserPrincipal);
                return RedirectToAction("ViewPosts", "Post");
            }
            return View();
        }

        public IActionResult UpdateUser(string username)
        {
            var model = UserProcessor.GetUserByUserName(username);
            var data = new UserModel
            {
                Email = model.Email,
                Password = model.Password,
                UserName = model.UserName,
                User_Id = model.User_Id
            };

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateUser(UserModel model)
        {
            UserProcessor.UpdateUser(model.Email, model.Password, model.UserName, HttpContext.GetCurrentUserModel().User_Id);
            return RedirectToAction("ViewPosts", "Post");
        }

        public IActionResult DetailsUser(string username)
        {
            var datamodel = UserProcessor.GetUserByUserName(username);
            UserModel data = new UserModel
            {
                CreationDate = datamodel.CreationDate,
                DateOfBirth = datamodel.DateOfBirth,
                Email = datamodel.Email,
                Password = datamodel.Password,
                Points = datamodel.Points,
                UserName = datamodel.UserName
            };
            return View(data);
        }
    }
}