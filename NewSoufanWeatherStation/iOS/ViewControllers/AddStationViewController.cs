using Foundation;
using System;
using UIKit;
using NewSoufanWeatherStation.iOS.Scripts;
using System.Threading;
using System.Threading.Tasks;

namespace NewSoufanWeatherStation.iOS
{
    public partial class AddStationViewController : UIViewController
    {
        private UIAlertView Alert = new UIAlertView();
        private LoadingOverlay loadPop;

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
            Task ts = ClickSubmit();

        }

        private async Task ClickSubmit()
        {
            var bounds = UIScreen.MainScreen.Bounds;

            loadPop = new LoadingOverlay(bounds); // using field from step 2
            this.NavigationController.View.Add(loadPop);
            await WaitFor();
            if ((NameTextField.Text.Equals("Backyard Station")) && (MacAddTextField.Text.Equals("535f69e40d3e9601")) && (SerialNumTextField.Text.Equals("KINEVANS70")))
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
            loadPop.Hide();
        }

        //private static void Waiting()
        //{
        //    Task ts = WaitFor();
        //}

        private static async Task WaitFor()
        {
            await Task.Delay(2000);

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