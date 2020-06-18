using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class SubscriptionDataModel
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string SubscriptionName { get; set; }
        public string Type { get; set; }
    }
}
