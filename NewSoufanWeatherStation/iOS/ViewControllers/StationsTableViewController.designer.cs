// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    [Register ("StationsTableViewController")]
    partial class StationsTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView StationsTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (StationsTable != null) {
                StationsTable.Dispose ();
                StationsTable = null;
            }
        }
    }
}