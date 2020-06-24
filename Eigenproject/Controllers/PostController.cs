using DataLayerLibrary.DataLogic;
using Eigenproject.Models.ViewModels;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Eigenproject.Models;

namespace Eigenproject.Controllers
{
    public class PostController : Controller
    {
        private readonly IWebHostEnvironment environment;

        public PostController(IWebHostEnvironment env)
        {
            environment = env;
        }
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(PostFileUploadViewModel post)
        {
            int file_id = 0;
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (post.File != null)
                {
                    string rootfolder = environment.WebRootPath;
                    string uploadsfolder = Path.Combine(environment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + post.File.FileName;
                    string path = Path.Combine(uploadsfolder, uniqueFileName);
                    post.File.CopyTo(new FileStream(path, FileMode.Create));
                    try
                    {
                        file_id = FileProcessor.GetFileId() + 1;
                    }
                    catch (Exception EX_NAME)
                    {
                        file_id = 1;
                    }
                    string DBFileName = "../images/" + uniqueFileName;
                    FileProcessor.CreateFile(DBFileName);
                    GenreProcessor.CheckGenreAndTryToSave(post.Genre);
                    TagsProcessor.CheckTagAndTryToSave(post.Tags);
                    PostProcessor.CreatePost
                    (
                        post.Title,
                        post.Tags,
                        post.Genre,
                        HttpContext.GetCurrentUserModel().User_Id,
                        file_id
                    );
                }
                return RedirectToAction("ViewPosts", "Post");
            }

            return View();
        }

        public IActionResult ViewPosts()
        {
            var data = PostProcessor.LoadPosts();
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                string fileLocation = FileProcessor.LoadFilePath(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = fileLocation,
                    ID = post.Post_Id,
                    Likes = post.Likes,
                    User_Id = post.User_Id
                });
            }

            posts.OrderByDescending(x => x.ID);
            return View(posts);
        }

        [HttpPost]
        public IActionResult AddLike([FromBody] string postId)
        {
            if (LikesProcessor.CheckIfLikedOrDisliked(HttpContext.GetCurrentUserModel().User_Id, Convert.ToInt32(postId)) == null)
            {
                PostProcessor.AddALikeToPost(Convert.ToInt32(postId));
                LikesProcessor.SaveLike(Convert.ToInt32(postId), HttpContext.GetCurrentUserModel().User_Id, true);

            }
            var data = PostProcessor.GetLikesOfPost(Convert.ToInt32(postId));
            return Json(data);
        }

        [HttpPost]
        public IActionResult AddDisLike([FromBody] string postId)
        {
            PostProcessor.RemoveALikeFromPost(Convert.ToInt32(postId));
            LikesProcessor.SaveLike(Convert.ToInt32(postId), HttpContext.GetCurrentUserModel().User_Id, false);
            var data = PostProcessor.GetLikesOfPost(Convert.ToInt32(postId));
            return Json(data);
        }

        [HttpPost]
        public IActionResult RemoveLikeOrDislike([FromBody] string postId)
        {
            bool? status = LikesProcessor.CheckIfLikedOrDisliked(HttpContext.GetCurrentUserModel().User_Id, Convert.ToInt32(postId));
            if (status == true)
            {
                PostProcessor.RemoveALikeFromPost(Convert.ToInt32(postId));
                LikesProcessor.RemoveLike(Convert.ToInt32(postId), HttpContext.GetCurrentUserModel().User_Id);
                var data = PostProcessor.GetLikesOfPost(Convert.ToInt32(postId));
                return Json(data);
            }
            else
            {
                PostProcessor.AddALikeToPost(Convert.ToInt32(postId));
                LikesProcessor.RemoveLike(Convert.ToInt32(postId), HttpContext.GetCurrentUserModel().User_Id);
                var data = PostProcessor.GetLikesOfPost(Convert.ToInt32(postId));
                return Json(data);
            }
        }

        public IActionResult GetPostsByTitle(string title)
        {
            var data = PostProcessor.GetPostsByTitle(title);
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                string fileLocation = FileProcessor.LoadFilePath(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = fileLocation,
                    ID = post.Post_Id,
                    Likes = post.Likes
                });
            }

            return View("ViewPosts", posts);
        }

        public IActionResult GetPostsByGenre(string genre)
        {
            var data = PostProcessor.GetPostsByGenre(genre);
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                string fileLocation = FileProcessor.LoadFilePath(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = fileLocation,
                    ID = post.Post_Id,
                    Likes = post.Likes,
                    User_Id = post.User_Id
                });
            }

            return View("ViewPosts", posts);
        }

        public IActionResult GetPostsByTag(string tag)
        {
            var data = PostProcessor.GetPostsByTag(tag);
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                string fileLocation = FileProcessor.LoadFilePath(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = fileLocation,
                    ID = post.Post_Id,
                    Likes = post.Likes,
                    User_Id = post.User_Id
                });
            }

            return View("ViewPosts", posts);
        }

        public IActionResult GetPostsByUserId(int user_Id)
        {
            var data = PostProcessor.GetPostsByUserId(user_Id);
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                string fileLocation = FileProcessor.LoadFilePath(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = fileLocation,
                    ID = post.Post_Id,
                    Likes = post.Likes,
                    User_Id = post.User_Id
                });
            }

            return View("ViewPosts", posts);
        }

        public IActionResult UpdatePost(int post_Id)
        {
            var data = PostProcessor.GetPostByPostId(post_Id);
            var filedata = FileProcessor.LoadFilePath(data.File_Id);
            var model = new PostFileViewModel
            {
                File = filedata,
                Genre = data.Genre,
                ID = data.Post_Id,
                Tags = data.Tags,
                Title = data.Title
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(PostFileViewModel model)
        {
            PostProcessor.UpdatePost(model.Title, model.Genre, model.Tags, model.ID);
            return RedirectToAction("ViewPosts", "Post");
        }

        public IActionResult DeletePost(int id)
        {
            var fileId = PostProcessor.GetPostByPostId(id).File_Id;
            PostProcessor.DeletePost(id);
            FileProcessor.DeleteFile(fileId);
            return RedirectToAction("ViewPosts", "Post");
        }
    }
}