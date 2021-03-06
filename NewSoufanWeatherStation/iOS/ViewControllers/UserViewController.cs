using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;
using NewSoufanWeatherStation.iOS.Scripts;

namespace NewSoufanWeatherStation.iOS
{
    public partial class UserViewController : UIViewController
    {
        private string FirstNameText, LastNameText, EmailText, PasswordText, PasswordConfText;
        private LoadingOverlay loadPop;

        public static Model.User TheUser;

        public UserViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.NavigationItem.SetHidesBackButton(true, false);
            this.TabBarController.NavigationItem.Title = "User View";
            this.TabBarController.NavigationItem.SetRightBarButtonItem(null, true);
            TextFieldsReturn();
            LoadDataFromSegue();
		}

        private void LoadDataFromSegue()
        {
            FirstNameTextField.Text = TheUser.FirstName;
            LastNameTextField.Text = TheUser.LastName;
            EmailTextField.Text = TheUser.Email;
            PasswordTextField.Text = TheUser.Password;
            PasswordConfTextField.Text = TheUser.Password;
        }

        public override void ViewDidAppear(bool animate)
        {
            this.TabBarController.NavigationItem.Title = "User View";
            this.TabBarController.NavigationItem.SetRightBarButtonItem(null, true);

        }

        partial void EditButton_TouchUpInside(UIButton sender)
        {
            Task ts = ClickEdit();
        }

        private async Task ClickEdit()
        {
            if (EditButton.TitleLabel.Text.Equals("Edit"))
            {
                UpdateUIElements("Save", true, 1, UITextBorderStyle.RoundedRect, (float)-7.0);
                FirstNameText = FirstNameTextField.Text;
                LastNameText = LastNameTextField.Text;
                EmailText = EmailTextField.Text;
                PasswordText = PasswordTextField.Text;
                PasswordConfText = PasswordConfTextField.Text;

            }
            else
            {
                if (CheckPasswordConfirmation())
                {
                    var bounds = UIScreen.MainScreen.Bounds;

                    loadPop = new LoadingOverlay(bounds); // using field from step 2
                    this.NavigationController.View.Add(loadPop);
                    await WaitFor();
                    UpdateUIElements("Edit", false, 0, UITextBorderStyle.None, (float)7.0);
                    loadPop.Hide();
                    UIAlertView alert = new UIAlertView() { Message = "Information Saved!!" };
                    alert.AddButton("OK");
                    alert.Show();
                }
                else
                {
                    UIAlertView alert = new UIAlertView() { Title = "Warning", Message = "Passowrds do not match", };
                    alert.AddButton("OK");
                    alert.Show();
                }

            }
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            UpdateUIElements("Edit", false, 0, UITextBorderStyle.None, (float)7.0);
            FirstNameTextField.Text = FirstNameText;
            LastNameTextField.Text = LastNameText;
            EmailTextField.Text = EmailText;
            PasswordTextField.Text = PasswordText;
            PasswordConfTextField.Text = PasswordConfText;
        }


        private bool CheckPasswordConfirmation()
        {
            return PasswordTextField.Text.Equals(PasswordConfTextField.Text);
        }

        private void UpdateUIElements(String buttonText, bool buttonEnabled, float buttonAlpha, UITextBorderStyle borderStyle, float offset)
        {
            EditButton.SetTitle(buttonText, UIControlState.Normal);
            CancelButton.Enabled = buttonEnabled;

            FirstNameTextField.Enabled = buttonEnabled;
            LastNameTextField.Enabled = buttonEnabled;
            EmailTextField.Enabled = buttonEnabled;
            PasswordTextField.Enabled = buttonEnabled;
            PasswordConfTextField.Enabled = buttonEnabled;
            PasswordConfLabel.Enabled = buttonEnabled;

            //Fade In/Out Animation
            double fadingDuration = 0.1;
            UIView.Animate(fadingDuration, 0, UIViewAnimationOptions.CurveEaseIn, () =>
            {
                CancelButton.Alpha = buttonAlpha;
                PasswordConfLabel.Alpha = buttonAlpha;
                PasswordConfTextField.Alpha = buttonAlpha;

                FirstNameTextField.BorderStyle = borderStyle;
                LastNameTextField.BorderStyle = borderStyle;
                EmailTextField.BorderStyle = borderStyle;
                PasswordTextField.BorderStyle = borderStyle;
                PasswordConfTextField.BorderStyle = borderStyle;


            }, null);

            //Fixing the offset after changing the border style
            FirstNameTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(FirstNameTextField.Frame.X + offset, FirstNameTextField.Frame.Y), FirstNameTextField.Frame.Size);
            LastNameTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(LastNameTextField.Frame.X + offset, LastNameTextField.Frame.Y), LastNameTextField.Frame.Size);
            EmailTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(EmailTextField.Frame.X + offset, EmailTextField.Frame.Y), EmailTextField.Frame.Size);
            PasswordTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(PasswordTextField.Frame.X + offset, PasswordTextField.Frame.Y), PasswordTextField.Frame.Size);
            PasswordConfTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(PasswordConfTextField.Frame.X + offset, PasswordConfTextField.Frame.Y), PasswordConfTextField.Frame.Size);

        }

        private void TextFieldsReturn()
        {
            this.FirstNameTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.LastNameTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.EmailTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.PasswordTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.PasswordConfTextField.ShouldReturn += (textField) =>
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