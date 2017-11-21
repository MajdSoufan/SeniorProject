using System;
using SQLite;
using System.Collections.Generic;


namespace NewSoufanWeatherStation.Model
{
    public class WeatherStation
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }

        public List<WeatherData> WeatherList { get; set; }

        public WeatherStation()
        {
            SetInitialWeatherData();
        }

        public WeatherStation(string serialNum, string macAdd, string theName)
        {
            SerialNumber = serialNum;
            MacAddress = macAdd;
            Name = theName;
            SetInitialWeatherData();
        }


        private void SetInitialWeatherData()
        {
            WeatherList = new List<WeatherData>();
            WeatherList.Add(new WeatherData
            {
                Temparature = 82,
                Date = new DateTime(2017, 10, 1)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 92,
                Date = new DateTime(2017, 10, 2)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 90,
                Date = new DateTime(2017, 10, 3)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 80,
                Date = new DateTime(2017, 10, 4)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 95,
                Date = new DateTime(2017, 10, 5)
            });

        }
    }
}
