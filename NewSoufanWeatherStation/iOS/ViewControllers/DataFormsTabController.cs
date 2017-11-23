using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS.ViewControllers
{
    public class DataFormsTabController : UITabBarController
    {

        public DataFormsTabController()
        {
            Title = "Temp";


        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.Title = "Temp";
            Title = "Temp";
        }

       
    }
}
