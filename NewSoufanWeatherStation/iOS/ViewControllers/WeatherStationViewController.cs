using Foundation;
using System;
using UIKit;

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
    }
}