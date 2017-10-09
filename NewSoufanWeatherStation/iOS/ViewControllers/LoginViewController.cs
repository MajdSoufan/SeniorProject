using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController (IntPtr handle) : base (handle)
        {
        }
		private int count = 1;

        public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			// Perform any additional setup after loading the view, typically from a nib.
			//Button.AccessibilityIdentifier = "myButton";
			//Button.TouchUpInside += delegate
			//{
			//	var title = string.Format("{0} clicks!", count++);
			//	Button.SetTitle(title, UIControlState.Normal);
			//};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.     
		}

		partial void ClickSignUpButton(UIButton sender)
		{
            
			//LabelSam.Text = "Sacw";
		}

        partial void ClickLoginButton(UIButton sender)
        {
            count++;
            //new UIAlertView("My Title Text", "This is my main text "+ count, null, "Ok", null).Show();

        }
    }
}