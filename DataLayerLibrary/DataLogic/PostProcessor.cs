using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
                File_Id = File_Id,
                Genre = genre,
                Likes = 0,
                User_Id = user_Id

            };
            string sql = "INSERT INTO post(User_Id, Title, File_Id, Tags, Genre, Creationdate, Likes) VALUES(@User_Id, @Title, @File_Id, @Tags, @Genre, @CreationDate, @Likes);";
            SQLAccessData.SaveData(sql, data);
        }

        public static List<PostDataModel> LoadPosts()
        {
            string sql = "SELECT * FROM post";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }

        public static void AddALikeToPost(int postId)
        {
            var data = postId;
            string sql = $"Update post set likes = likes + 1 WHERE Post_Id = '{postId}';";
            SQLAccessData.SaveData(sql, data);
        }

        public static void RemoveALikeFromPost(int postId)
        {
            var data = postId;
            string sql = $"Update post set likes = likes - 1 WHERE Post_Id = '{postId}';";
            SQLAccessData.SaveData(sql, data);
        }

        public static int GetLikesOfPost(int post_Id)
        {
            string sql = $"Select likes FROM post WHERE Post_Id = '{post_Id}';";
            return SQLAccessData.LoadFirstEntry<int>(sql);
        }

        public static List<PostDataModel> GetPostsByTitle(string title)
        {
            string sql = $"SELECT * FROM post WHERE Title LIKE '%{title}%';";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }

        public static List<PostDataModel> GetPostsByGenre(string genre)
        {
            string sql = $"SELECT * FROM post WHERE Genre = '{genre}';";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }

        public static List<PostDataModel> GetPostsByTag(string tag)
        {
            string sql = $"SELECT * FROM post WHERE Tags = '{tag}';";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }

        public static List<PostDataModel> GetPostsByUserId(int user_Id)
        {
            string sql = $"SELECT * FROM post WHERE User_Id = '{user_Id}';";
            return SQLAccessData.LoadData<PostDataModel>(sql);
        }

        public static PostDataModel GetPostByPostId(int post_Id)
        {
            string sql = $"SELECT * FROM post WHERE Post_Id = '{post_Id}';";
            return SQLAccessData.LoadFirstEntry<PostDataModel>(sql);
        }

        public static void UpdatePost(string title, string genre, string tag, int id)
        {
            var data = new PostDataModel
            {
                Title = title,
                Genre = genre,
                Tags = tag
            };
            string sql = $"Update post Set Title = '{title}', Genre = '{genre}', Tags = '{tag}' WHERE Post_Id = '{id}';";
            SQLAccessData.SaveData(sql, data);
        }

        public static void DeletePost(int id)
        {
            string sql = $"Delete from post WHERE post_id = '{id}';";
            SQLAccessData.DeleteData(sql);
        }
    }
}
