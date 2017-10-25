using System;
using SQLite;

namespace NewSoufanWeatherStation.Model
{
    public class WeatherStation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }
        public string Name { get; set; }


        public WeatherStation()
        {
        }

        public WeatherStation(string serialNum, string macAdd, string theName)
        {
            SerialNumber = serialNum;
            MacAddress = macAdd;
            Name = theName;
        }
    }
}
