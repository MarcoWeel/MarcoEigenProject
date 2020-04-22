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
            string sql = "INSERT INTO file(File_Location) VALUES(@Location);";
            SQLAccessData.SaveData(sql,data);
        }

        public static FileDataModel LoadFile(int Id)
        {
            string sql = $"SELECT * FROM file WHERE File_Id = '{Id}'";
            return SQLAccessData.LoadFirstEntry<FileDataModel>(sql);
        }

        public static int GetFileId(string location)
        {
            string sql = $"SELECT * FROM file WHERE File_Location = '{location}'";
            var data = SQLAccessData.LoadFirstEntry<FileDataModel>(sql);
            return data.Id;
        }
    }
}
