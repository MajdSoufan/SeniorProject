using Foundation;
using System;
using System.IO;
using SQLite;
using UIKit;

namespace NewSoufanWeatherStation.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public static string DataBase_Path = string.Empty;

        public LoginViewController(IntPtr handle) : base(handle)
        {
            var documentsFolder = Environment.GetFolderPath((Environment.SpecialFolder.Personal));
            DataBase_Path = Path.Combine(documentsFolder, "weather_station_db.db");

            using (var connection = new SQLite.SQLiteConnection(DataBase_Path))
            {
                connection.CreateTable<Model.User>();
                connection.CreateTable<Model.WeatherStation>();
            }

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

           
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }

        partial void ClickSignUpButton(UIButton sender)
        {

        }

        partial void ClickLoginButton(UIButton sender)
        {
            
        }
    }
}