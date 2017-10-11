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
                UpdateEditCancelButtonsStatus("Save", true, 1);
            }
            else
            {
                UpdateEditCancelButtonsStatus("Edit", false, 0);
            }
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            UpdateEditCancelButtonsStatus("Edit", false, 0);
        }

        private void UpdateEditCancelButtonsStatus(String buttonText, bool buttonEnabled, float buttonAlpha)
        {
            EditButton.SetTitle(buttonText, UIControlState.Normal);
            CancelButton.Enabled = buttonEnabled;

            //Fade In/Out Animation
            double fadingDuration = 0.1;
            UIView.Animate(fadingDuration, 0, UIViewAnimationOptions.CurveEaseIn, ()=>
            {
                CancelButton.Alpha = buttonAlpha;
            },null);
        }
    }
}