using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using UIKit;
using System.Threading.Tasks;
using System.Runtime;
using NewSoufanWeatherStation.iOS.Scripts;
using System.Linq;

namespace NewSoufanWeatherStation.iOS
{
    public partial class LoginViewController : UIViewController
    {
        private LoadingOverlay loadPop;
        public static List<Model.User> UsersList;


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

            UsersList = new List<Model.User>();
            UsersList.Add(new Model.User() {FirstName = "Majd", LastName = "Soufan",Email="ms585@evansville.edu", Password="Google12345"});


        }


        partial void ClickSignUpButton(UIButton sender)
        {

        }

        partial void  ClickLoginButton(UIButton sender)
        {
            Task ts = ClickLogin();
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
            var Alert = new UIAlertView();

            if(CredentialsExistInDataBase())
            {
                
            }
            else
            {
                Alert.Message = "Login info do not exist in database!! ";
                Alert.AddButton("Ok");
                Alert.Show();

            }

            loadPop.Hide();
        }

        private bool CredentialsExistInDataBase()
        {
            List<string> nameList = UsersList.Select((obj) => obj.FirstName).ToList();
            List<string> passwordList = UsersList.Select((obj) => obj.Password).ToList();

            return ((nameList.Contains(UserNameTextField.Text)) && (passwordList.Contains(PasswordTextField.Text)));

        }

        private static async Task WaitFor()
        {
            await Task.Delay(2000);

        }
    }
}