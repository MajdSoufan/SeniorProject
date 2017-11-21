using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS.ViewControllers
{
    public class DataFormsTabController : UITabBarController
    {
        public Model.WeatherStation WeatherStation { get; set; }

        public DataFormsTabController()
        {


            var tab1 = new DataForm1Controller();
            tab1.Title = "Form 1";
            tab1.TabBarItem.TitlePositionAdjustment = new UIOffset(0, -15);

            var tab2 = new DataForm2Controller();
            tab2.Title = "Form 2";
            tab2.TabBarItem.TitlePositionAdjustment = new UIOffset(0, -15);

            var tab3 = new DataForm3Controller();
            tab3.Title = "Form 3";
            tab3.TabBarItem.TitlePositionAdjustment = new UIOffset(0, -15);

            var tabs = new UIViewController[] {
                                tab1, tab2, tab3
                        };

            ViewControllers = tabs;


        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


        }

    }
}
