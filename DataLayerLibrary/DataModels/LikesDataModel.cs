using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    class LikesDataModel
    {
        public int ID { get; set; }
        public int User_Id { get; set; }
        public int Post_Id { get; set; }
        public bool Type { get; set; }
    }
}
