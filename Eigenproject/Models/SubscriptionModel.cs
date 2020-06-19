using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eigenproject.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Name { get; set; }
    }
}
