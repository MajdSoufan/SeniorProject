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
    [Register ("SignUpViewController")]
    partial class SignUpViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calendarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submitButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (calendarButton != null) {
                calendarButton.Dispose ();
                calendarButton = null;
            }

            if (submitButton != null) {
                submitButton.Dispose ();
                submitButton = null;
            }
        }
    }
}