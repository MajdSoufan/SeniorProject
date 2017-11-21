using System;
using SQLite;
using System.Collections.Generic;
using Foundation;
using System.IO;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public class DataBaseInitiatior
    {

        public static string DataBase_Path = string.Empty;

        public DataBaseInitiatior()
        {
            var documentsFolder = Environment.GetFolderPath((Environment.SpecialFolder.Personal));
            DataBase_Path = Path.Combine(documentsFolder, "weather_station_db.db");

            using (var dbConnection = new SQLite.SQLiteConnection(DataBase_Path))
            {
                dbConnection.CreateTable<Model.User>();
                dbConnection.CreateTable<Model.WeatherStation>();

            }

        }

        public static void SetDataBasePath(string folderPath)
        {
            var documentsFolder = Environment.GetFolderPath((Environment.SpecialFolder.Personal));
            DataBase_Path = Path.Combine(documentsFolder, folderPath);

        }

        public static void CreateTable(string tableName)
        {


        }

    }
}
