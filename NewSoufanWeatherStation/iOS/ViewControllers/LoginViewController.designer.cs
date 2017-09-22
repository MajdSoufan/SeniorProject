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
        UIKit.UITextField LoginTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTextField { get; set; }

        [Action ("ClickLoginButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClickLoginButton (UIKit.UIButton sender);

        [Action ("ClickSignUpButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClickSignUpButton (UIKit.UIButton sender);


        void ReleaseDesignerOutlets ()
        {
            if (LoginTextField != null) {
                LoginTextField.Dispose ();
                LoginTextField = null;
            }

            if (PasswordTextField != null) {
                PasswordTextField.Dispose ();
                PasswordTextField = null;
            }
        }
    }
}