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

        partial void EditButton_TouchUpInside(UIButton sender)
        {
            if (EditButton.TitleLabel.Text.Equals("Edit"))
            {
                UpdateUIElements("Save", true, 1, UITextBorderStyle.RoundedRect, (float)-7.0);
            }
            else
            {
                UpdateUIElements("Edit", false, 0, UITextBorderStyle.None, (float)7.0);

            }
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            UpdateUIElements("Edit", false, 0, UITextBorderStyle.None, (float)7.0);
        }


        private void UpdateUIElements(String buttonText, bool buttonEnabled, float buttonAlpha, UITextBorderStyle borderStyle, float offset)
        {
            EditButton.SetTitle(buttonText, UIControlState.Normal);
            CancelButton.Enabled = buttonEnabled;

            FirstNameTextField.Enabled = buttonEnabled;
            LastNameTextField.Enabled = buttonEnabled;
            EmailTextField.Enabled = buttonEnabled;
            PasswordTextField.Enabled = buttonEnabled;

            //Fade In/Out Animation
            double fadingDuration = 0.1;
            UIView.Animate(fadingDuration, 0, UIViewAnimationOptions.CurveEaseIn, () =>
            {
                CancelButton.Alpha = buttonAlpha;
                FirstNameTextField.BorderStyle = borderStyle;
                LastNameTextField.BorderStyle = borderStyle;
                EmailTextField.BorderStyle = borderStyle;
                PasswordTextField.BorderStyle = borderStyle;

            }, null);

            //Fixing the offset after changing the border style
            FirstNameTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(FirstNameTextField.Frame.X + offset, FirstNameTextField.Frame.Y), FirstNameTextField.Frame.Size);
            LastNameTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(LastNameTextField.Frame.X + offset, LastNameTextField.Frame.Y), LastNameTextField.Frame.Size);
            EmailTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(EmailTextField.Frame.X + offset, EmailTextField.Frame.Y), EmailTextField.Frame.Size);
            PasswordTextField.Frame = new CoreGraphics.CGRect(new CoreGraphics.CGPoint(PasswordTextField.Frame.X + offset, PasswordTextField.Frame.Y), PasswordTextField.Frame.Size);

        }

      
    }
}