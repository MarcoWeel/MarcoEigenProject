using System;
using System.Collections.Generic;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class FileProcessor
    {
        public static void CreateFile(string location)
        {
            FileDataModel data = new FileDataModel
            {
                Location = location
            };
            string sql = "INSERT INTO file(Location) VALUES(@Location);";
            SQLAccessData.SaveData(sql, data);
        }

        public static FileDataModel LoadFile(int id)
        {
            string sql = $"Select * FROM file WHERE File_Id = '{id}';";
            var data = SQLAccessData.LoadFirstEntry<FileDataModel>(sql);
            return data;
        }

        public static string LoadFilePath(int id)
        {
            string sql = $"Select Location FROM file WHERE File_Id = '{id}';";
            var data = SQLAccessData.LoadFirstEntry<string>(sql);
            return data;
        }


        public static int GetFileId()
        {
            try
            {
                string sql = $"SELECT MAX(File_Id) FROM file LIMIT 1;";
                var data = SQLAccessData.LoadFirstEntry<int>(sql);
                return data;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static void DeleteFile(int id)
        {
            string sql = $"Delete FROM file WHERE file_id = '{id}';";
            SQLAccessData.DeleteData(sql);
        }
    }
}
