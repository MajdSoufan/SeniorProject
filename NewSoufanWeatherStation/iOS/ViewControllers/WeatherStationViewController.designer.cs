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
    [Register ("WeatherStationViewController")]
    partial class WeatherStationViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel FilterLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView FilterView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MacAddLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SerialNumberLabel { get; set; }

        [Action ("WeatherInfoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WeatherInfoButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (FilterLabel != null) {
                FilterLabel.Dispose ();
                FilterLabel = null;
            }

            if (FilterView != null) {
                FilterView.Dispose ();
                FilterView = null;
            }

            if (MacAddLabel != null) {
                MacAddLabel.Dispose ();
                MacAddLabel = null;
            }

            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (SerialNumberLabel != null) {
                SerialNumberLabel.Dispose ();
                SerialNumberLabel = null;
            }
        }
    }
}