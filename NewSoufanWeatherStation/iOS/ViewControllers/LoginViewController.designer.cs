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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelSam { get; set; }

        [Action ("Button_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Button_TouchUpInside (UIKit.UIButton sender);

        [Action ("ClickButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClickButton (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Button != null) {
                Button.Dispose ();
                Button = null;
            }

            if (LabelSam != null) {
                LabelSam.Dispose ();
                LabelSam = null;
            }
        }
    }
}