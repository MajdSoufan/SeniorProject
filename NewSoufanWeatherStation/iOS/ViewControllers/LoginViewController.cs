using Foundation;
using System;
using System.IO;
using SQLite;
using UIKit;
using System.Threading.Tasks;
using System.Runtime;

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
            LoginButton.Layer.BackgroundColor = View.TintColor.CGColor;
            SignUpButton.Layer.BackgroundColor = View.TintColor.CGColor;
            this.UserNameTextField.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };
            this.PasswordTextField.ShouldReturn += (textField) => {
                textField.ResignFirstResponder();
                return true;
            };


        }


        partial void ClickSignUpButton(UIButton sender)
        {

        }

        partial void  ClickLoginButton(UIButton sender)
        {

        }

        private bool CheckAccountLoginInfo()
        {
            return true;
        }
    }
}