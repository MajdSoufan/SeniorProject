using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS.ViewControllers
{
    public class DataFormsTabController : UITabBarController
    {

        public DataFormsTabController()
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.NavigationItem.Title = "Temp";
        }

       
    }
}
