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
    [Register ("UserViewController")]
    partial class UserViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EditButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EmailTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FirstNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LastNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PasswordConfLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordConfTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTextField { get; set; }

        [Action ("CancelButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CancelButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("EditButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EditButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CancelButton != null) {
                CancelButton.Dispose ();
                CancelButton = null;
            }

            if (EditButton != null) {
                EditButton.Dispose ();
                EditButton = null;
            }

            if (EmailTextField != null) {
                EmailTextField.Dispose ();
                EmailTextField = null;
            }

            if (FirstNameTextField != null) {
                FirstNameTextField.Dispose ();
                FirstNameTextField = null;
            }

            if (LastNameTextField != null) {
                LastNameTextField.Dispose ();
                LastNameTextField = null;
            }

            if (PasswordConfLabel != null) {
                PasswordConfLabel.Dispose ();
                PasswordConfLabel = null;
            }

            if (PasswordConfTextField != null) {
                PasswordConfTextField.Dispose ();
                PasswordConfTextField = null;
            }

            if (PasswordTextField != null) {
                PasswordTextField.Dispose ();
                PasswordTextField = null;
            }
        }
    }
}