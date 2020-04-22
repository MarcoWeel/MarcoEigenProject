using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class PostDataModel
    {
        public int User_Id { get; set; }
        public string Title { get; set; }
        public int File_Id { get; set; }
        public string Tags { get; set; }
        public string Genre { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public int Likes { get; set; }
    }
}
