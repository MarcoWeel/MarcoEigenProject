using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using Eigenproject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace Eigenproject.Controllers
{
    public class PostController : Controller
    {
        public IActionResult CreatePost(PostFileViewModel post)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (post.File != null)
                {
                    string uploadsfolder = "G:/ServerFiles";
                    uniqueFileName = post.File.FileName + "_" + Guid.NewGuid().ToString();
                    string path = Path.Combine(uploadsfolder, uniqueFileName);
                    post.File.CopyTo(new FileStream(path, FileMode.Create));
                }
                //    PostProcessor.CreatePost
                //    (
                //        post.Title,
                //        post.Tags,
                //        post.Genre,
                //        post.User_Id,
                //        post.File_Id
                //    );
                //    return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult ViewPosts()
        {
            var data = PostProcessor.LoadPosts();
            List<PostModel> posts = new List<PostModel>();
            foreach (var post in data)
            {
                posts.Add(new PostModel
                    {
                    Title = post.Title,
                    CreationDate = post.CreationDate,
                    File_Id = post.File_Id,
                    Genre = post.Genre,
                    Id = post.Id,
                    Likes = post.Likes,
                    Tags = post.Tags,
                    User_Id = post.User_Id
                    }
                );
                
            }
            return View(posts);
        }
    }
}