using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;
using LogicLayerLibrary;


namespace DataLayerLibrary.DataLogic
{
    public class UserProcessor
    {
        public static void CreateUser(string email, DateTime dateOfBirth, string password, string userName, string salt)
        {
            UserDataModel data = new UserDataModel
            {
                Email = email,
                DateOfBirth = dateOfBirth,
                CreationDate = DateTime.Now,
                Password = password,
                Salt = salt,
                Points = 0,
                UserName = userName
            };
            string sql = @"INSERT INTO user (Email, DateOfBirth, Username, Password, Salt, CreationDate, Points)
                            VALUES(@Email, @DateOfBirth, @UserName, @Password, @Salt, @CreationDate, @Points);";
            SQLAccessData.SaveData(sql, data);
        }

        public static List<UserDataModel> LoadUsers()
        {
            string sql = "SELECT * FROM user;";
            return SQLAccessData.LoadData<UserDataModel>(sql);
        }

        public static UserDataModel GetUserByUserName(string userName)
        {
            string sql = $"SELECT * FROM user WHERE Username = '{userName}';";
            return SQLAccessData.LoadFirstEntry<UserDataModel>(sql);
        }

        public static void DeleteUser(int id)
        {
            string sql = $"DELETE FROM user WHERE User_Id = '{id}';";
            SQLAccessData.DeleteData(sql);
        }

        public static void UpdateUser(string email, string password, string username, int id)
        {
            UserDataModel data = new UserDataModel
            {
                Email = email,
                Password = password,
                UserName = username
            };

            string sql = $"Update user Set Email = '{email}', Password = '{password}', Username = '{username}' WHERE User_Id = '{id}';";
            SQLAccessData.SaveData(sql, data);
        }
    }
}
