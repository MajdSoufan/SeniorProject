using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class UserViewController : UIViewController
    {
        private string FirstNameText, LastNameText, EmailText, PasswordText, PasswordConfText;

        public UserViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.NavigationItem.SetHidesBackButton(true, false);
		}

        partial void EditButton_TouchUpInside(UIButton sender)
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
                    UpdateUIElements("Edit", false, 0, UITextBorderStyle.None, (float)7.0);
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

      
    }
}