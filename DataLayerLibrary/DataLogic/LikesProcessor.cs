using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
     public class LikesProcessor
    {
        public static void SaveLike(int post_Id, int User_Id, bool type)
        {
            LikesDataModel data = new LikesDataModel
            {
                Post_Id = post_Id,
                User_Id = User_Id,
                Type = type
            };
            string sql = @"INSERT INTO likes (Post_Id, User_Id, Type) VALUES(@Post_Id, User_Id, Type);";
            SQLAccessData.SaveData(sql,data);
        }

        public static bool? CheckIfLikedOrDisliked(int User_Id, int Post_Id)
        {
            string sql = $"SELECT Type FROM likes WHERE Post_Id = '{Post_Id}' AND User_Id = '{User_Id}';";
            try
            {
                return SQLAccessData.LoadFirstEntry<bool>(sql);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void RemoveLike(int post_Id, int user_Id)
        {
            string sql = $"DELETE FROM likes WHERE Post_Id = '{post_Id}' AND User_Id = '{user_Id}';";
            SQLAccessData.DeleteData(sql);
        }

        public static void ChangeLikeStatus(int post_Id, int user_Id, bool type)
        {
            LikesDataModel data = new LikesDataModel
            {
                Post_Id = post_Id,
                User_Id = user_Id,
                Type = type
            };

            string sql = $"UPDATE likes SET Type = '{type}' WHERE Post_Id = '{post_Id}' AND User_Id = '{user_Id}';";
            SQLAccessData.SaveData(sql, data);
        }
    }
}
