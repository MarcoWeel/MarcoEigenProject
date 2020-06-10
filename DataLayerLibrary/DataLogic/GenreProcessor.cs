using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class GenreProcessor
    {
        private static void SaveGenre(string name)
        {
            GenreDataModel data = new GenreDataModel
            {
                name = name
            };
            string sql = @"INSERT INTO genre (name) VALUES (@name);";
            SQLAccessData.SaveData(sql, data);
        }

        public void CheckGenreAndTryToSave(string name)
        {
            bool exists = false;
            string sql = $"SELECT * FROM genre WHERE name = '{name}'";
            try
            {
                SQLAccessData.LoadFirstEntry<GenreDataModel>(sql);
            }
            catch (Exception e)
            {
                exists = true;
            }

            if (exists == false)
            {
                SaveGenre(name);
            }

        }

        public List<GenreDataModel> GetAllGenres()
        {
            string sql = "SELECT * FROM genre;";
            return SQLAccessData.LoadData<GenreDataModel>(sql);
        }
    }
}
