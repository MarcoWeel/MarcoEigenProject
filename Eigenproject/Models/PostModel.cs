using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eigenproject.Models
{
    public class PostModel
    {
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Vul een titel in")]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        public int File_Id { get; set; }
        [Display(Name = "Tags")]
        public string Tags { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public int Likes { get; set; }
    }
}
