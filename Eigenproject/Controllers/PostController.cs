﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Eigenproject.Models;
using Eigenproject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Renci.SshNet;

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

                    int file_id = FileProcessor.GetFileId() + 1;

                    FileProcessor.CreateFile(path.Replace(@"\", @"\\"));

                    PostProcessor.CreatePost
                    (
                        post.Title,
                        post.Tags,
                        post.Genre,
                        1,
                        file_id
                    );
                }
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult ViewPostsold()
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

        public IActionResult ViewPosts()
        {
            var data = PostProcessor.LoadPosts();
            List<PostFileViewModel> posts = new List<PostFileViewModel>();
            foreach (var post in data)
            {
                FileDataModel FileLocation = FileProcessor.LoadFile(post.File_Id);
                posts.Add(new PostFileViewModel
                {
                    Title = post.Title,
                    Tags = post.Tags,
                    Genre = post.Genre,
                    File = FileLocation.Location
                });
            }
            return View(posts);
        }
    }
}