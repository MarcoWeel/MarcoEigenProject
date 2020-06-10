using System;
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

        public void CheckTagAndTryToSave(string name)
        {
            bool exists = false;
            string sql = $"SELECT * FROM tags WHERE name = '{name}'";
            try
            {
                SQLAccessData.LoadFirstEntry<TagsDataModel>(sql);

            }
            catch (Exception e)
            {
                exists = true;
            }

            if (exists == false)
            {
                SaveTag(name);
            }
        }

        public List<TagsDataModel> GetAllTags()
        {
            string sql = "SELECT * FROM tags;";
            return SQLAccessData.LoadData<TagsDataModel>(sql);
        }
    }
}
