﻿using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class TagsProcessor
    {
        private static void SaveTag(string name)
        {
            TagsDataModel data = new TagsDataModel
            {
                name = name
            };
            string sql = @"INSERT INTO tags (name) VALUES (@name);";
            SQLAccessData.SaveData(sql, data);
        }

        public static void CheckTagAndTryToSave(string name)
        {
            bool exists = true;
            string sql = $"SELECT * FROM tags WHERE name = '{name}'";
            try
            {
                SQLAccessData.LoadFirstEntry<TagsDataModel>(sql);

            }
            catch (Exception e)
            {
                exists = false;
            }

            if (exists == false)
            {
                SaveTag(name);
            }
        }

        public static List<TagsDataModel> GetAllTags()
        {
            string sql = "SELECT * FROM tags;";
            return SQLAccessData.LoadData<TagsDataModel>(sql);
        }

        public static TagsDataModel GetTagByName(string name)
        {
            string sql = $"SELECT * FROM tags WHERE name = '{name}'";
            return SQLAccessData.LoadFirstEntry<TagsDataModel>(sql);
        }
    }
}
