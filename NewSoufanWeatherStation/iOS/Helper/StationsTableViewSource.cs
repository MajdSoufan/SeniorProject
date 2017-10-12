using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace NewSoufanWeatherStation.iOS
{
    public class StationsTableViewSource : UITableViewSource
    {
        private List<string> serialNums;

        public StationsTableViewSource()
        {
        }

        public StationsTableViewSource(List<string> serialNums)
        {
            this.serialNums = serialNums;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");

            cell.TextLabel.Text = serialNums[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return serialNums.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var selectedSerialNum = serialNums[indexPath.Row];
        }
    }
}
