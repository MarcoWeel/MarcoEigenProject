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

        public static UserDataModel GetUserByUserName(string UserName)
        {
            string sql = $"SELECT * FROM user WHERE Username = '{UserName}';";
            return SQLAccessData.LoadFirstEntry<UserDataModel>(sql);
        }

        public static void DeleteUser(int id)
        {
            string sql = $"DELETE FROM user WHERE Id = '{id}';";
            SQLAccessData.DeleteData(sql);
        }
    }
}
