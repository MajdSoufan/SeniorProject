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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TextFieldsReturn();

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

        private void TextFieldsReturn()
        {
            this.NameTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.MacAddTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };
            this.SerialNumTextField.ShouldReturn += (textField) =>
            {
                textField.ResignFirstResponder();
                return true;
            };

        }
    }
}