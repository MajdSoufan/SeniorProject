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
        public float Pressure { get; set; }

        public DateTime Date { get; set; }

        public WeatherData()
        {
        }

        public WeatherData(float temp, float pressure, float wind, float hum, DateTime date)
        {
            Temparature = temp;
            WindSpeed = wind;
            Pressure = pressure;
            Humidity = hum;
            Date = date;
        }

        public string PrintDate()
        {
            //string year = Date.Year.ToString().Substring(2);
            string year = "17";
            return Date.Month.ToString() + "/" + Date.Day.ToString() + "/" + year;
        }

    }
}
