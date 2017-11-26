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
        private UIBarButtonItem AddButton = new UIBarButtonItem();


        public StationsTableViewController (IntPtr handle) : base (handle)
        {
            StationsList = new List<Model.WeatherStation>();
            ConstructWeatherStations();
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            AddButton.Title = "Add";

            this.TabBarController.NavigationItem.SetRightBarButtonItem(AddButton
                , true);
    
            StationsTable.Source = new StationsTableViewSource(this, StationsList);

            this.TabBarController.NavigationItem.Title = "Stations";
        }

        public override void ViewDidAppear(bool animated)
        {
            AddButton.Title = "Add";

            this.TabBarController.NavigationItem.SetRightBarButtonItem(AddButton
                , true);

            this.TabBarController.NavigationItem.Title = "Stations";
        }

        private void ConstructWeatherStations()
        {
            StationsList.Add(new Model.WeatherStation("011232342423", "110.22.13.11", "Backyard Station"));
            //StationsList.Add(new Model.WeatherStation("019488238423", "113.12.73.12", "Frontyard Station"));
            //StationsList.Add(new Model.WeatherStation("019090807014", "144.25.63.13", "Porch Station"));
            //StationsList.Add(new Model.WeatherStation("011209887766", "155.52.23.14", "Barn Station"));

        }
    }
}