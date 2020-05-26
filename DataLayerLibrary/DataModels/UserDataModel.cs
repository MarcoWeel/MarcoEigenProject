using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class UserDataModel
    {
        public int Id { get; set; } 
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime CreationDate { get; set; }
        public int Points { get; set; }
    }
}
