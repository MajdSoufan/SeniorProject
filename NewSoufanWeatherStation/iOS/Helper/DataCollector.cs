using Foundation;
using System;
using UIKit;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using CreativeGurus.Weather.Wunderground;
using CreativeGurus.Weather.Wunderground.Models;
using System.Threading.Tasks;
using System.Runtime;

namespace NewSoufanWeatherStation.iOS.Helper
{
    public class DataCollector
    {
        private static string Key = "535f69e40d3e9601";

        public DataCollector()
        {
        }

        public async static void GetData()
        {
            await ConnectWithServer();
        }

        private static async Task<bool> ConnectWithServer()
        {
            try
            {
               
                WeatherClient client = new WeatherClient(Key);


                //Sample History
                var history = await client.GetHistoryAsync(QueryType.PWSId, new QueryOptions {  PWSId = "KINEVANS70", Date = new DateTime(2017, 11, 23)});

                var temperature = history.History.Observations[0].Tempi;
                var rain = history.History.Observations[0].Precipi;
                var wind = history.History.Observations[0].Wspdi;
                var humidty = history.History.Observations[0].Hum;

                var Alert = new UIAlertView();
                Alert.Message = "User created successfully!!" ;
                Alert.AddButton("Ok");
                Alert.Show();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
