using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;
using BarChart;

namespace NewSoufanWeatherStation.iOS
{
    public partial class WeatherStationViewController : UIViewController
    {
        public Model.WeatherStation WeatherStation;
        private List<UISwitch> SwitchesList;

        public WeatherStationViewController (IntPtr handle) : base (handle)
        {
        }

        public WeatherStationViewController() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SwitchesList = new List<UISwitch>();
            AddSwitches();
            AddFunctionalityToSwitches();

            FilterLabel.Layer.BorderColor = UIColor.Black.CGColor;
            FilterLabel.Layer.BorderWidth = 2;
            // Perform any additional setup after loading the view, typically from a nib.
            NameLabel.Text = WeatherStation.Name;
            SerialNumberLabel.Text = WeatherStation.SerialNumber;
            MacAddLabel.Text = WeatherStation.MacAddress;

            this.Title = "Weather Stataion Data";
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);
            var weatherStationViewController = segue.DestinationViewController as WeatherStationViewController;

            if (weatherStationViewController != null)
            {
                weatherStationViewController.WeatherStation = WeatherStation;

            }
        }


        partial void WeatherInfoButton_TouchUpInside(UIButton sender)
        {

            //DataForm1Controller dataForm1TabController = this.Storyboard.InstantiateViewController
            //            ("DataForm1Controller") as DataForm1Controller;
            //if (dataForm1TabController != null)
            //{
            //    //dataForm1TabController.WeatherStation = this.WeatherStation;
            //    DataForm1Controller.WeatherStation = this.WeatherStation;

            //    this.NavigationController.PushViewController(dataForm1TabController, true);

            //}
            DataForm1Controller.WeatherStation = this.WeatherStation;
            DataForm2Controller.WeatherStation = this.WeatherStation;
            DataForm3Controller.WeatherStation = this.WeatherStation;

            Helper.FilterObject fileteredDataObject = new Helper.FilterObject
            {
                Data = GetDataChosen(),
                StartDate = WeatherStation.WeatherList.First().Date,
                EndDate = WeatherStation.WeatherList.Last().Date
            };

            DataForm1Controller.FilteredObject = fileteredDataObject;
            DataForm2Controller.FilteredObject = fileteredDataObject;
            DataForm3Controller.FilteredObject = fileteredDataObject;

            Helper.DataCollector.GetData();

        }

        private void AddSwitches()
        {
            SwitchesList.Add(TempSwitch);
            SwitchesList.Add(RainSwitch);
            SwitchesList.Add(WindSwitch);
            SwitchesList.Add(HumiditySwitch);
        }

        private void AddFunctionalityToSwitches()
        {
            SwitchesList.ForEach((uiSwitch)=>
            {
                uiSwitch.TouchUpInside += (sender,e) => 
                { 
                    SwitchesList.ForEach((eSwitch)=>
                    {
                        if (!eSwitch.Equals(uiSwitch))
                        {
                            eSwitch.On = false;                                
                        }
                    });
                };
            });
        }

        private Helper.FilteredData GetDataChosen()
        {
            Helper.FilteredData data = Helper.FilteredData.Temp;

            SwitchesList.ForEach((uiSwitch)=>
            {
                if(uiSwitch.On)
                {
                    data = GetDataChosenHelper(uiSwitch);
                }
            });

            return data;
        }

        private Helper.FilteredData GetDataChosenHelper(UISwitch eSwitch)
        {
            if (eSwitch.Equals(TempSwitch))
            {
                return Helper.FilteredData.Temp;
            }
            else if (eSwitch.Equals(RainSwitch))
            {
                return Helper.FilteredData.Rain;
            }
            else if (eSwitch.Equals(WindSwitch))
            {
                return Helper.FilteredData.Wind;
            }
            else
            {
                return Helper.FilteredData.Humidity;
            }
        }

    }
}