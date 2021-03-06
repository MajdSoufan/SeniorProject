using Foundation;
using System;
using UIKit;
using TimesSquare.iOS;
using System.Threading.Tasks;
using NewSoufanWeatherStation.iOS.Scripts;

namespace NewSoufanWeatherStation.iOS
{
    public partial class SignUpViewController : UIViewController
    {
        private UIAlertView Alert = new UIAlertView();
        private LoadingOverlay loadPop;

        public SignUpViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            TextFieldsReturn();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.     
		}

        partial void SubmitButton_TouchUpInside(UIButton sender)
        {
            Task ts = ClickSubmit();
        }

        private async Task ClickSubmit()
        {

            ClearAllValidation();
            ValidateEntries(FirstNameField);
            ValidateEntries(LastNameField);
            ValidateEntries(EmailField);
            ValidateEntries(PasswordField);
            ValidateEntries(PasswordConfField);

            if (!IsEmptyEntries())
            {
                if (PasswordConfirmation())
                {
                    var bounds = UIScreen.MainScreen.Bounds;

                    loadPop = new LoadingOverlay(bounds); // using field from step 2
                    this.NavigationController.View.Add(loadPop);
                    CreateNewUser();
                    await WaitFor();



                    loadPop.Hide();
                    Alert.Message = "User created successfully!!";
                    Alert.AddButton("Ok");
                    Alert.Show();

                    ClearAllValidation();
                }
                else
                {
                    
                    Alert.Message = "Failed!! Password don't match";
                    Alert.AddButton("Ok");
                    Alert.Show();

                }

            }
            else
            {
                Alert.Message = "Failed!! Input error";
                Alert.AddButton("Ok");
                Alert.Show();

            }
        }

        private void CreateNewUser()
        {
            LoginViewController.UsersList.Add(new Model.User() { FirstName = FirstNameField.Text, LastName = LastNameField.Text, Email = EmailField.Text, Password = PasswordField.Text});

        }

        private void ValidateEntries(UITextField textField)
        {
            if (textField.Text.Trim().Length <= 0)
            {
                InvokeOnMainThread(() =>
                {
                    textField.Layer.BorderColor = UIColor.Red.CGColor;
                    textField.Layer.BorderWidth = 3;
                    textField.Layer.CornerRadius = 5;
                });
                return;
            }

        }

        private bool IsEmptyEntries()
        {
            return 
                (FirstNameField.Text.Trim().Equals(string.Empty)) || 
                (LastNameField.Text.Trim().Equals(string.Empty)) || 
                (EmailField.Text.Trim().Equals(string.Empty)) || 
                (PasswordField.Text.Trim().Equals(string.Empty)) || 
                (PasswordConfField.Text.Trim().Equals(string.Empty));
        }

        private void ClearAllValidation()
        {
            InvokeOnMainThread(() =>
            {
                FirstNameField.Layer.BorderWidth = 0;
                FirstNameField.Layer.CornerRadius = 0;
                LastNameField.Layer.BorderWidth = 0;
                LastNameField.Layer.CornerRadius = 0;
                EmailField.Layer.BorderWidth = 0;
                EmailField.Layer.CornerRadius = 0;
                PasswordField.Layer.BorderWidth = 0;
                PasswordField.Layer.CornerRadius = 0;
                PasswordConfField.Layer.BorderWidth = 0;
                PasswordConfField.Layer.CornerRadius = 0;
            });

        }

        private bool PasswordConfirmation()
        {
            return PasswordField.Text.Equals(PasswordConfField.Text);
        }

        private void TextFieldsReturn()
        {
            this.FirstNameField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.LastNameField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.EmailField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.PasswordField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.PasswordConfField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
        }

        private static async Task WaitFor()
        {
            await Task.Delay(2000);

        }
    }
}