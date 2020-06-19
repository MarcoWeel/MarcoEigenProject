using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataLogic;
using Eigenproject.Models;

namespace DataLayerLibrary.ViewComponents
{
    public class GenreSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var data = SubscriptionProcessor.GetFiveMostRecurringGenres();
            List<GenreModel> genres = new List<GenreModel>();
            foreach (var row in data)
            {
                var genreData = GenreProcessor.GetGenreByName(row.SubscriptionName);
                genres.Add(new GenreModel()
                    {
                        Id = genreData.ID,
                        Name = genreData.name
                    }
                );
            }
            return View(genres);
        }
    }
}
