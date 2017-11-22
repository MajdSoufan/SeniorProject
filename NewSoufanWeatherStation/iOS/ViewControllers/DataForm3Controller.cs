using Foundation;
using System;
using UIKit;
using Alliance.Charts;
using System.Collections.Generic;

namespace NewSoufanWeatherStation.iOS
{
    public partial class DataForm3Controller : UIViewController
    {
        public static Model.WeatherStation WeatherStation { get; set; }
        public AllianceChart AllianceChart { get; set; }

        public DataForm3Controller (IntPtr handle) : base (handle)
        {
        }

        public DataForm3Controller() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.AllianceChart = new AllianceChart(Chart.Line, this.SubView);      
            createLineChart();


            this.SubView.SetNeedsDisplay();
        }

        public void createLineChart()
        {
            List<string> X_labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            AllianceChart.LineChartView.XLabels = X_labels;
            AllianceChart.LineChartView.PopOverTextColor = UIColor.Black;
            List<ChartComponent> components = new List<ChartComponent>();

            WeatherStation.WeatherList.ForEach((weatherData) =>
            { 
                ChartComponent ChartComponent = new ChartComponent();
                ChartComponent.Name = weatherData.PrintDate();
                ChartComponent.value = weatherData.Temparature;
                ChartComponent.color = UIColor.FromRGB(23f / 255f, 169f / 255f, 227f / 255f);
                ChartComponent.lableColor = UIColor.Black;
                components.Add(ChartComponent);
            });



            // Add more ChartComponent for more Lines in the Line Chart

            AllianceChart.LoadChart(components, Chart.Line, this.SubView);

        }
    }
}