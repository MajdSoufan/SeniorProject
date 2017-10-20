using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using System.Linq;

namespace NewSoufanWeatherStation.iOS
{
    public partial class StationsTableViewController : UITableViewController
    {
        public List<Model.WeatherStation> StationsList { get; set; }

        public StationsTableViewController (IntPtr handle) : base (handle)
        {
            StationsList = new List<Model.WeatherStation>();
            ConstructWeatherStations();
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var serialNums = StationsList.Select((obj) =>  obj.SerialNumber).ToList();

            StationsTable.Source = new StationsTableViewSource(serialNums);
        }

        private void ConstructWeatherStations()
        {
            StationsList.Add(new Model.WeatherStation("011232342423", "110.22.13.11"));
            StationsList.Add(new Model.WeatherStation("019488238423", "113.12.73.12"));
            StationsList.Add(new Model.WeatherStation("019090807014", "144.25.63.13"));
            StationsList.Add(new Model.WeatherStation("011209887766", "155.52.23.14"));

        }
    }
}