using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class UserTabViewController : UITabBarController
    {
        public UserTabViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //this.NavigationItem.SetRightBarButtonItem(
            //new UIBarButtonItem(UIImage.FromFile("blue.png")
            //, UIBarButtonItemStyle.Plain
            //, (sender, args) => {
            //     // button was clicked
            // })
            //, true);
            this.NavigationItem.SetHidesBackButton(true, false);
        }
    }
}