using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Eigenproject.Models
{
    public class FileModel
    {
        public int Id { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload bestand")]
        [Required(ErrorMessage = "Voeg een bestand toe")]
        public string Location { get; set; }
    }
}
