﻿using System;
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
            string sql = @"INSERT INTO genre(name) VALUES (@name);";
            SQLAccessData.SaveData(sql, data);
        }

        public static void CheckGenreAndTryToSave(string name)
        {
            bool exists = true;
            string sql = $"SELECT * FROM genre WHERE name = '{name}'";
            try
            {
                SQLAccessData.LoadFirstEntry<GenreDataModel>(sql);
            }
            catch (Exception e)
            {
                exists = false;
            }

            if (exists == false)
            {
                SaveGenre(name);
            }

        }

        public static List<GenreDataModel> GetAllGenres()
        {
            string sql = "SELECT * FROM genre;";
            return SQLAccessData.LoadData<GenreDataModel>(sql);
        }

        public static GenreDataModel GetGenreByName(string name)
        {
            string sql = $"SELECT * FROM genre WHERE name = '{name}'";
            return SQLAccessData.LoadFirstEntry<GenreDataModel>(sql);
        }
    }
}
