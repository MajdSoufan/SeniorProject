using System;
namespace NewSoufanWeatherStation.Model
{
    public class WeatherStation
    {
        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }

        public WeatherStation()
        {
        }

        public WeatherStation(string serialNum, string macAdd)
        {
            SerialNumber = serialNum;
            MacAddress = macAdd;
        }
    }
}
