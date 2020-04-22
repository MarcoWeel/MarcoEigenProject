using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class PostProcessor
    {
        public static void CreatePost(string title, string tags, string genre, int user_Id, int File_Id)
        {
            PostDataModel data = new PostDataModel
            {
                Title = title,
                Tags = tags,
                CreationDate = DateTime.Now,
                File_Id = 1,
                Genre = genre,
                Likes = 0,
                User_Id = user_Id

            };
            string sql = "INSERT INTO post (User_Id, Name, File_Id, Tags, Genre, Creationdate, Likes)" +
                         "VALUES (@user_Id, @Title @File_Id, @Tags, @Genre, @ CreationDate, @Likes);";
            SQLAccessData.SaveData(sql, data);
        }

        public static List<PostDataModel> LoadPosts()
        {
            string sql = "SELECT * FROM post";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }
    }
}
