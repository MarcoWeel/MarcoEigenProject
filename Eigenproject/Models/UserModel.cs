using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Eigenproject.Models
{
    public class UserModel
    {
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Vul een E-mail in")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vul een geboortedatum in")]
        [Display(Name = "geboortedatum")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Vul een gebruikersnaam in")]
        [Display(Name = "Gebruikersnaam")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vul een wachtwoord in")]
        [Display(Name = "Wachtwoord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreationDate { get; set; }
        public int Points { get; set; }

    }
}
