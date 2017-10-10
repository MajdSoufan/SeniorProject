using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }

        partial void ClickSignUpButton(UIButton sender)
        {

        }

        partial void ClickLoginButton(UIButton sender)
        {
            // How to create a segue with out storyboard
            //UserViewController userView = this.Storyboard.InstantiateViewController("UserViewController") as UserViewController;
            //this.NavigationController.PushViewController(userView, true);
        }
    }
}