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
using System.Globalization;

namespace NewSoufanWeatherStation.iOS.Helper
{
    public class DataCollector
    {
        private static string Key = "535f69e40d3e9601";

        public async static Task<Model.WeatherData> GetData(DateTime date)
        {
           return await ConnectWithServer(date);
            //var Alert = new UIAlertView();
            //Alert.Message = "User created successfully!! " + list.Temparature;
            //Alert.AddButton("Ok");
            //Alert.Show();
        }

        private static async Task<Model.WeatherData> ConnectWithServer(DateTime date)
        {
            Model.WeatherData dataList = new Model.WeatherData(); 

            try
            {
               
                WeatherClient client = new WeatherClient(Key);

                //Sample History
                var history = await client.GetHistoryAsync(QueryType.PWSId, new QueryOptions {  PWSId = "KINEVANS70", Date = new DateTime(date.Year, date.Month,date.Day)});


                if (history.History.Observations.Length > 0)
                {
                    var emparature = float.Parse(history.History.Observations[0].Tempi, CultureInfo.InvariantCulture.NumberFormat);
                    var rainAm = float.Parse(history.History.Observations[0].Dewptm, CultureInfo.InvariantCulture.NumberFormat);
                    var windSp = float.Parse(history.History.Observations[0].Wspdi, CultureInfo.InvariantCulture.NumberFormat);
                    var humD = float.Parse(history.History.Observations[0].Hum, CultureInfo.InvariantCulture.NumberFormat);
                    var dateTod = new DateTime(date.Year, date.Month, date.Day);

                    dataList = new Model.WeatherData(emparature, rainAm, windSp, humD, dateTod);
                    //dataList = new Model.WeatherData(float.Parse(history.History.Observations[0].Tempi, CultureInfo.InvariantCulture.NumberFormat), float.Parse(history.History.Observations[0].Precipi, CultureInfo.InvariantCulture.NumberFormat),
                                                     //float.Parse(history.History.Observations[0].Wspdi, CultureInfo.InvariantCulture.NumberFormat), float.Parse(history.History.Observations[0].Hum, CultureInfo.InvariantCulture.NumberFormat),
                                                     //new DateTime(date.Year, date.Month, date.Day));
                    //{
                        //Temparature = float.Parse(history.History.Observations[0].Tempi, CultureInfo.InvariantCulture.NumberFormat),
                        //RainAmount = float.Parse(history.History.Observations[0].Precipi, CultureInfo.InvariantCulture.NumberFormat),
                        //WindSpeed = float.Parse(history.History.Observations[0].Wspdi, CultureInfo.InvariantCulture.NumberFormat),
                        //Humidity = float.Parse(history.History.Observations[0].Hum, CultureInfo.InvariantCulture.NumberFormat),
                        //Date = new DateTime(date.Year, date.Month, date.Day)
                    //};
                }
                else
                {
                    dataList = new Model.WeatherData(0.0f, 0.0f, 0.0f, 0.0f, new DateTime(date.Year, date.Month, date.Day));
                    //{
                    //    Temparature = 0.0f,
                    //    RainAmount = 0.0f,
                    //    WindSpeed = 0.0f,
                    //    Humidity = 0.0f,
                    //    Date = new DateTime(date.Year, date.Month, date.Day)
                                    
                    //};

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
