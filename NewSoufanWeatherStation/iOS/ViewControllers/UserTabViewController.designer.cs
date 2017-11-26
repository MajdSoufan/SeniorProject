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
    [Register ("UserTabViewController")]
    partial class UserTabViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITabBar UserTabBar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (UserTabBar != null) {
                UserTabBar.Dispose ();
                UserTabBar = null;
            }
        }
    }
}