using Foundation;
using System;
using UIKit;
using System.Linq;
using BarChart;

namespace NewSoufanWeatherStation.iOS
{
    public partial class WeatherStationViewController : UIViewController
    {
        public Model.WeatherStation WeatherStation;

        public WeatherStationViewController (IntPtr handle) : base (handle)
        {
        }

        public WeatherStationViewController() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NameLabel.Text = WeatherStation.Name;
            SerialNumberLabel.Text = WeatherStation.SerialNumber;
            MacAddLabel.Text = WeatherStation.MacAddress;

            this.Title = "Weather Stataion Data";
            InstantiateChart();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var weatherStationViewController = segue.DestinationViewController as WeatherStationViewController;

            if (weatherStationViewController != null)
            {
                weatherStationViewController.WeatherStation = WeatherStation;

            }
        }

        private void InstantiateChart()
        {
            var tempData = WeatherStation.WeatherList.Select((obj) => obj.Temparature).ToArray();
            var chart = new BarChartView
            {
                Frame = View.Frame,
                ItemsSource = Array.ConvertAll(tempData, v => new BarModel { Value = v })
            };

            View.AddSubview(chart);

        }
    }
}