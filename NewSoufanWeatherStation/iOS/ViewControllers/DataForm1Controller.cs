using Foundation;
using System;
using UIKit;
using BarChart;
using System.Linq;

namespace NewSoufanWeatherStation.iOS
{
    public partial class DataForm1Controller : UIViewController
    {
        public static Model.WeatherStation WeatherStation { get; set; }

        public DataForm1Controller (IntPtr handle) : base (handle)
        {
        }

        public DataForm1Controller() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            InstantiateChart();
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            //var dataForm1Controller = segue.DestinationViewController as DataForm1Controller;

            //if (dataForm1Controller != null)
            //{
            //    dataForm1Controller.WeatherStation = WeatherStation;

            //}
        }

        private void InstantiateChart()
        {
            

            var tempData = WeatherStation.WeatherList.Select((obj) => obj.Temparature).ToArray();
            var chart = new BarChartView
            {
                Frame = View.Frame,
                ItemsSource = Array.ConvertAll(tempData, v => new BarModel { Value = v })
            };

            this.View.AddSubview(chart);

        }
    }
}