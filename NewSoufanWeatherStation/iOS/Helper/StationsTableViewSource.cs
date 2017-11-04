using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using System.Linq;

namespace NewSoufanWeatherStation.iOS
{
    public class StationsTableViewSource : UITableViewSource
    {
        private List<string> StationsNames;
        private List<Model.WeatherStation> StationsList;
        private StationsTableViewController Parent;

        public StationsTableViewSource()
        {
        }

        public StationsTableViewSource(StationsTableViewController parent,List<Model.WeatherStation> weatherStations)
        {
            StationsList = weatherStations;
            this.StationsNames = weatherStations.Select((obj) => obj.Name).ToList();
            Parent = parent;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");

            cell.TextLabel.Text = StationsNames[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return StationsNames.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var stationSelected = StationsList.Find((item) => item.Name.Equals(StationsNames[indexPath.Row]));
            WeatherStationViewController weatherStationViewController = Parent.Storyboard.InstantiateViewController
                                                                              ("WeatherStationViewController") as WeatherStationViewController;
            if (weatherStationViewController != null)
            {
                weatherStationViewController.WeatherStation = stationSelected;
                Parent.NavigationController.PushViewController(weatherStationViewController, true);

            }
          
            // var controller = new WeatherStationViewController(this);
            tableView.DeselectRow(indexPath, true);

        }
    }
}
