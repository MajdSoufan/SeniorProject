﻿using Foundation;
using System;
using UIKit;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using CreativeGurus.Weather.Wunderground;
using CreativeGurus.Weather.Wunderground.Models;
using System.Threading.Tasks;
using System.Runtime;
using System.Globalization;

namespace NewSoufanWeatherStation.iOS.Helper
{
    public class DataCollector
    {
        private static string Key = "535f69e40d3e9601";

        public async static Task<Model.WeatherData> GetData(Model.WeatherData list)
        {
           return await ConnectWithServer();
            //var Alert = new UIAlertView();
            //Alert.Message = "User created successfully!! " + list.Temparature;
            //Alert.AddButton("Ok");
            //Alert.Show();
        }

        private static async Task<Model.WeatherData> ConnectWithServer()
        {
            Model.WeatherData dataList = new Model.WeatherData(); 

            try
            {
               
                WeatherClient client = new WeatherClient(Key);


                //Sample History
                var history = await client.GetHistoryAsync(QueryType.PWSId, new QueryOptions {  PWSId = "KINEVANS70", Date = new DateTime(2017, 11, 24)});


                if (history.History.Observations.Length > 0)
                {
                    dataList = new Model.WeatherData
                    {
                        Temparature = float.Parse(history.History.Observations[0].Tempi, CultureInfo.InvariantCulture.NumberFormat),
                        RainAmount = float.Parse(history.History.Observations[0].Precipi, CultureInfo.InvariantCulture.NumberFormat),
                        WindSpeed = float.Parse(history.History.Observations[0].Wspdi, CultureInfo.InvariantCulture.NumberFormat),
                        Humidity = float.Parse(history.History.Observations[0].Hum, CultureInfo.InvariantCulture.NumberFormat)
                    };
                }
                else
                {
                    dataList = new Model.WeatherData
                    {
                        Temparature = 0.0f,
                        RainAmount = 0.0f,
                        WindSpeed = 0.0f,
                        Humidity = 0.0f
                    };

                }
                 

               

                return dataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataList;
            }
        }
    }
}
