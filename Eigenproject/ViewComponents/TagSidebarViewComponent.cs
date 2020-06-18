using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using Eigenproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eigenproject.ViewComponents
{
    public class TagSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var data = SubscriptionProcessor.GetFiveMostRecurringTags();
            List<TagModel> tags = new List<TagModel>();
            foreach (var row in data)
            {
                var tagData = TagsProcessor.GetTagByName(row.SubscriptionName);
                tags.Add(new TagModel
                {
                    Id = tagData.ID,
                    Name = tagData.name
                }
                );
            }
            return View(tags);
        }
    }
}
