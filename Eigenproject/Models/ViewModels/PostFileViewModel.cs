using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Eigenproject.Models.ViewModels
{
    public class PostFileViewModel
    {
        [Required(ErrorMessage = "Fill in a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public int User_Id { get; set; }

        public int File_Id { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "File")]
        [Required(ErrorMessage = "Add a file")]
        public string File { get; set; }
        public int ID { get; set; }
        public int Likes { get; set; }
    }
}
