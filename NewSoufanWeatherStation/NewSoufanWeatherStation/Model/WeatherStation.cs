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
                RainAmount = 15,
                WindSpeed = 70,
                Humidity = 60,
                Date = new DateTime(2017, 10, 1)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 92,
                RainAmount = 12,
                WindSpeed = 20,
                Humidity = 70,
                Date = new DateTime(2017, 10, 2)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 90,
                RainAmount = 7,
                WindSpeed = 45,
                Humidity = 50,
                Date = new DateTime(2017, 10, 3)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 80,
                RainAmount = 20,
                WindSpeed = 89,
                Humidity = 40,
                Date = new DateTime(2017, 10, 4)
            });
            WeatherList.Add(new WeatherData
            {
                Temparature = 95,
                RainAmount =17,
                WindSpeed = 66,
                Humidity = 85,
                Date = new DateTime(2017, 10, 5)
            });

        }
    }
}
