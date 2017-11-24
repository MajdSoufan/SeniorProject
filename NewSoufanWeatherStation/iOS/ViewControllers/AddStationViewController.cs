using Foundation;
using System;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class AddStationViewController : UIViewController
    {
        private UIAlertView Alert = new UIAlertView();

        public AddStationViewController (IntPtr handle) : base (handle)
        {
        }


        partial void SubmitButton_TouchUpInside(UIButton sender)
        {
            if((NameTextField.Text.Equals(""))&&(MacAddTextField.Text.Equals(""))&&(SerialNumTextField.Text.Equals("")))
            {
                Alert.Message = "Station is already added!!";
                Alert.AddButton("Ok");
                Alert.Show();
            }
            else
            {
                Alert.Message = "Station is not found!!";
                Alert.AddButton("Ok");
                Alert.Show();
            }

        }
    }
}