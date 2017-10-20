using System;
namespace NewSoufanWeatherStation.Model
{
    public class WeatherStation
    {
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
