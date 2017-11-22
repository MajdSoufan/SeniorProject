using System;
using SQLite;

namespace NewSoufanWeatherStation.Model
{
    public class WeatherData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int Temparature { get; set; }
        public int WindSpeed { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public int RainAmount { get; set; }
        public string WindDirection { get; set; }

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
