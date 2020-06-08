using System.Linq;
using System.Security.Claims;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using Microsoft.AspNetCore.Http;

namespace LogicLayerLibrary.ExtensionMethods
{
    public static class UserExtensionMethods
    {
        public static UserModel GetCurrentUserModel(this HttpContext httpContext)
        {
            Claim username = httpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
            if (username == null) return null;
            UserDataModel dataModel = UserProcessor.GetUserByUserName(username.Value);
            UserModel model = new UserModel
            {
                Email = dataModel.Email,
                Points = dataModel.Points,
                User_Id = dataModel.Id,
                UserName = dataModel.UserName
            };
            return model;
        }
    }
}
