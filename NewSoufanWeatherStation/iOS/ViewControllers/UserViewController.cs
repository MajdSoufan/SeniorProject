using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class UserViewController : UIViewController
    {
        public UserViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.NavigationItem.SetHidesBackButton(true, false);
		}
    }
}