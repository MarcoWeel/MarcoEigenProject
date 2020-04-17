using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class UserProcessor
    {
        public static void CreateUser(string email, DateTime dateOfBirth, string password, string userName)
        {
            UserDataModel data = new UserDataModel
            {
                Email = email,
                DateOfBirth = dateOfBirth,
                CreationDate = DateTime.Now,
                Password = password,
                Points = 0,
                UserName = userName
            };
            string sql = @"INSERT INTO user (Email, DateOfBirth, Username, Password, CreationDate, Points)
                            VALUES(@Email, @DateOfBirth, @UserName, @Password, @CreationDate, @Points);";
            SQLAccessData.SaveData(sql, data);
        }

        public static List<UserDataModel> LoadUsers()
        {
            string sql = "SELECT * FROM user;";
            return SQLAccessData.LoadData<UserDataModel>(sql);
        }

        public static List<UserDataModel> GetUserByUserName(string UserName)
        {
            string sql = $"SELECT * FROM user WHERE Username = '{UserName}';";
            return SQLAccessData.LoadData<UserDataModel>(sql);
        }

        public static void DeleteUser(int id)
        {
            string sql = $"DELETE FROM user WHERE User_Id = '{id}';";
            SQLAccessData.DeleteData(sql);
        }
    }
}
