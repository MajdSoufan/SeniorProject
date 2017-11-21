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


        partial void WeatherInfoButton_TouchUpInside(UIButton sender)
        {
            //ViewControllers.DataFormsTabController dataFormTabController = this.Storyboard.InstantiateViewController
            //    ("ViewControllers.DataFormsTabController") as ViewControllers.DataFormsTabController;
            //if (dataFormTabController != null)
            //{
            //    dataFormTabController.WeatherStation = this.WeatherStation;
            //    this.NavigationController.PushViewController(dataFormTabController, true);

            //}

            DataForm1Controller dataForm1TabController = this.Storyboard.InstantiateViewController
                        ("DataForm1Controller") as DataForm1Controller;
            if (dataForm1TabController != null)
            {
                dataForm1TabController.WeatherStation = this.WeatherStation;
                this.NavigationController.PushViewController(dataForm1TabController, true);

            }
        }
    }
}