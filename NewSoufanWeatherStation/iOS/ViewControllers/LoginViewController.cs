using Foundation;
using System;
using System.IO;
using SQLite;
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
            //new DataBaseInitiatior();
           
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
            
        }
    }
}