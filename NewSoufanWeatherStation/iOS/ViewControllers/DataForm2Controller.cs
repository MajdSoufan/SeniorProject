using Foundation;
using System;
using UIKit;
using Alliance.Charts;
using System.Collections.Generic;

namespace NewSoufanWeatherStation.iOS
{
    public partial class DataForm2Controller : UIViewController
    {
        public static Model.WeatherStation WeatherStation { get; set; }
        public static Helper.FilterObject FilteredObject { get; set; }

        public AllianceChart AllianceChart { get; set; }


        public DataForm2Controller (IntPtr handle) : base (handle)
        {
        }

        public DataForm2Controller() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.AllianceChart = new AllianceChart(Chart.Bar, this.SubView);
            createBarChart();


            this.SubView.SetNeedsDisplay();
        }

        public void createBarChart()
        {

            AllianceChart.BarChart.SetupBarViewShape(BarShape.Rounded);
            AllianceChart.BarChart.SetupBarViewStyle(BarDisplayStyle.BarStyleMatte);
            AllianceChart.BarChart.SetupBarViewShadow(BarShadow.Light);
            AllianceChart.BarChart.barWidth = 15;

            List<ChartComponent> Components = new List<ChartComponent>();

            WeatherStation.WeatherList.ForEach((weatherData)=>
            {
                ChartComponent ChartComponent = new ChartComponent();
                ChartComponent.Name = weatherData.PrintDate();

                if (GetChosenData(weatherData) == 0.0f)
                    ChartComponent.value = 0.1f;
                else
                    ChartComponent.value = GetChosenData(weatherData);
                
                ChartComponent.color = UIColor.FromRGB(135f / 255f, 227f / 255f, 23f / 255f);
                ChartComponent.lableColor = UIColor.Black;
                Components.Add(ChartComponent);
            
            });



            //Add more ChartComponent for more Bars



            AllianceChart.LoadChart(Components, Chart.Bar, this.SubView);

        }

        private float GetChosenData(Model.WeatherData weatherData)
        {
            if (FilteredObject.Data.Equals(Helper.FilteredData.Temp))
            {
                return weatherData.Temparature;
            }
            else if (FilteredObject.Data.Equals(Helper.FilteredData.Rain))
            {
                return weatherData.RainAmount;
            }
            else if (FilteredObject.Data.Equals(Helper.FilteredData.Wind))
            {
                return weatherData.WindSpeed;
            }
            else
            {
                return weatherData.Humidity;
            }

        }

    }
}