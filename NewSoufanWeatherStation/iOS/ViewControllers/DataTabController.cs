using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class DataTabController : UITabBarController
    {
        public DataTabController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            NavigationItem.Title = DataForm1Controller.FilteredObject.Data.ToString();
        }

    }
}