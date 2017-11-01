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

            using (var connection = new SQLite.SQLiteConnection(DataBase_Path))
            {
                connection.CreateTable<Model.User>();
               // connection.CreateTable<Model.WeatherStation>();
            }

        }

    }
}
