using System;
using SQLite;

namespace NewSoufanWeatherStation.Model
{
    public class WeatherData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public float Temparature { get; set; }
        public float WindSpeed { get; set; }
        public float Humidity { get; set; }
        public float RainAmount { get; set; }

        public DateTime Date { get; set; }

        public WeatherData()
        {
        }

        public string PrintDate()
        {
            string year = Date.Year.ToString().Substring(2);
            return Date.Month.ToString() + "/" + Date.Day.ToString() + "/" + year;
        }

    }
}
