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
            ChartComponent.Name = "temp";

            List<float?> values = new List<float?>();
            WeatherStation.WeatherList.ForEach((weatherData) =>
            {
                values.Add(weatherData.Temparature);
            });
            ChartComponent.valueList = values;
            ChartComponent.color = UIColor.FromRGB(23f / 255f, 169f / 255f, 227f / 255f);
            ChartComponent.lableColor = UIColor.Black;
            components.Add(ChartComponent);


            // Add more ChartComponent for more Lines in the Line Chart

            TheAllianceChart.LoadChart(components, Chart.Line, this.SubView);

        }




    }
}