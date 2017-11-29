using Foundation;
using System;
using System.IO;
using SQLite;
using UIKit;
using System.Threading.Tasks;
using System.Runtime;
using NewSoufanWeatherStation.iOS.Scripts;

namespace NewSoufanWeatherStation.iOS
{
    public partial class LoginViewController : UIViewController
    {
        private LoadingOverlay loadPop;


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
           // Task ts = ClickLogin();
        }

        private bool CheckAccountLoginInfo()
        {
            return true;
        }

        private async Task ClickLogin()
        {
            var bounds = UIScreen.MainScreen.Bounds;

            loadPop = new LoadingOverlay(bounds); // using field from step 2
            this.NavigationController.View.Add(loadPop);
            await WaitFor();

            loadPop.Hide();
        }

        private static async Task WaitFor()
        {
            await Task.Delay(2000);

        }
    }
}