using Foundation;
using System;
using UIKit;
using System.Linq;
using Alliance.Charts;
using System.Collections.Generic;


namespace NewSoufanWeatherStation.iOS
{
    public partial class DataForm1Controller : UIViewController
    {
        public static Model.WeatherStation WeatherStation { get; set; }
        public static Helper.FilterObject FilteredObject { get; set; }
        public AllianceChart TheAllianceChart { get; set; }

        public DataForm1Controller (IntPtr handle) : base (handle)
        {
        }

        public DataForm1Controller() : base()
        {
        }

        public override void ViewDidLoad ()
        {   
            base.ViewDidLoad();

            NavigationItem.Title = FilteredObject.Data.ToString();

            this.TheAllianceChart = new AllianceChart(Chart.Line, this.SubView);      
            createLineChart();


            this.SubView.SetNeedsDisplay();
        } 




        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

        }

        public void createLineChart()
        {

            TheAllianceChart.LineChartView.XLabels = WeatherStation.WeatherList.Select((obj) => obj.PrintDate()).ToList(); ;
            TheAllianceChart.LineChartView.PopOverTextColor = UIColor.White;
            List<ChartComponent> components = new List<ChartComponent>();

            ChartComponent ChartComponent = new ChartComponent();
            ChartComponent.Name = "data";

            List<float?> values = new List<float?>();
            WeatherStation.WeatherList.ForEach((weatherData) =>
            {
                values.Add(GetChosenData(weatherData));
            });
            ChartComponent.valueList = values;
            ChartComponent.color = UIColor.FromRGB(23f / 255f, 169f / 255f, 227f / 255f);
            ChartComponent.lableColor = UIColor.Black;
            components.Add(ChartComponent);


            // Add more ChartComponent for more Lines in the Line Chart

            TheAllianceChart.LoadChart(components, Chart.Line, this.SubView);

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