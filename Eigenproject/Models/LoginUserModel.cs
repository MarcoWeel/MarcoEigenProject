using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eigenproject.Models
{
    public class LoginUserModel
    {
        [Display(Name = "Gebruikersnaam")]
        [Required(ErrorMessage = "Vul een gebruikersnaam in")]
        public string Username { get; set; }

        [Display(Name = "Wachtwoord")]
        [Required(ErrorMessage = "Vul een wachtwoord in")]
        public string Password { get; set; }
    }
}
