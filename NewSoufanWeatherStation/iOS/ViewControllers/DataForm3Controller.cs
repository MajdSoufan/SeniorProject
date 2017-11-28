using Foundation;
using System;
using UIKit;
using Alliance.Charts;
using System.Collections.Generic;
using System.Linq;

namespace NewSoufanWeatherStation.iOS
{
    public partial class DataForm3Controller : UIViewController
    {
        public static Model.WeatherStation WeatherStation { get; set; }
        public static Helper.FilterObject FilteredObject { get; set; }

        public AllianceChart TheAllianceChart { get; set; }

        public DataForm3Controller (IntPtr handle) : base (handle)
        {
        }

        public DataForm3Controller() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.TheAllianceChart = new AllianceChart(Chart.Pie, this.SubView);
            createPieChart();

            this.SubView.SetNeedsDisplay();
        }

        public void createPieChart()
        {
            List<ChartComponent> Components = new List<ChartComponent>();

            Random rand = new Random();

            WeatherStation.WeatherList.ForEach((weatherData) =>
            {
                ChartComponent ChartComponent = new ChartComponent();

                int randomColorNum = rand.Next(255);

                ChartComponent.Name = weatherData.PrintDate();
                ChartComponent.value = GetChosenData(weatherData);
                ChartComponent.color = GetRandomColor(randomColorNum);

                ChartComponent.lableColor = UIColor.Black;
                Components.Add(ChartComponent);

            });


            //Add more ChartComponent for more Slices in Pie Chart

            TheAllianceChart.LoadChart(Components, Chart.Pie, this.SubView);
        }

        public UIColor GetRandomColor(int hue)
        {
            return UIColor.FromHSB((hue / 255.0f), 1.0f, 1.0f);
        }

        private float GetChosenData(Model.WeatherData weatherData)
        {
            if (FilteredObject.Data.Equals(Helper.FilteredData.Temp))
            {
                return weatherData.Temparature;
            }
            else if (FilteredObject.Data.Equals(Helper.FilteredData.Pressure))
            {
                return weatherData.Pressure;
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