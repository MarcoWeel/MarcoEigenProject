using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Eigenproject.Models.ViewModels
{
    public class PostFileUploadViewModel
    {
        [Required(ErrorMessage = "Add a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public int File_Id { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload file")]
        [Required(ErrorMessage = "Add a file")]
        public IFormFile File { get; set; }
    }
}
