using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace Eigenproject.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult GetListOfSubscriptionViaUserId(int user_Id)
        {
            List<SubscriptionDataModel> data = SubscriptionProcessor.GetSubscriptionsViaUserId(user_Id);
            List<SubscriptionModel> subscriptions = new List<SubscriptionModel>();
            foreach (var subscription in data)
            {
                subscriptions.Add(new SubscriptionModel
                {
                    Name = subscription.SubscriptionName,
                    Id = subscription.Id,
                    User_Id = subscription.User_Id
                });
            }

            if (data.Count == 0)
            {
                subscriptions = null;
            }

            return View(subscriptions);
        }

        [HttpPost]
        public IActionResult AddGenreSubscription([FromBody]string subscriptionName)
        {
            SubscriptionProcessor.CreateSubscription(subscriptionName, "Genre", HttpContext.GetCurrentUserModel().User_Id);
            return null;
        }

        [HttpPost]
        public IActionResult AddUserSubscription([FromBody]string subscriptionName)
        {
            SubscriptionProcessor.CreateSubscription(subscriptionName, "User", HttpContext.GetCurrentUserModel().User_Id);
            return null;
        }

        [HttpPost]
        public IActionResult AddTagSubscription([FromBody]string subscriptionName)
        {
            SubscriptionProcessor.CreateSubscription(subscriptionName, "Tag", HttpContext.GetCurrentUserModel().User_Id);
            return null;
        }

        [HttpPost]
        public IActionResult RemoveSubscription([FromBody] string subscriptionName)
        {
            SubscriptionProcessor.RemoveSubscription(HttpContext.GetCurrentUserModel().User_Id, subscriptionName);
            return null;
        }
    }
}