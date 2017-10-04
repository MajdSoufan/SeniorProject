using Foundation;
using System;
using UIKit;
using TimesSquare.iOS;

namespace NewSoufanWeatherStation.iOS
{
    public partial class SignUpViewController : UIViewController
    {
        public SignUpViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var calendarView = new TSQCalendarView(View.Bounds)
            {
                Calendar = new Foundation.NSCalendar(Foundation.NSCalendarType.Gregorian),
                FirstDate = Foundation.NSDate.Now,
                BackgroundColor = UIColor.LightTextColor,
                PagingEnabled = true
            };

            calendarView.DidSelectDate += (sender, e) => 
            {
                var netDate = (DateTime)e.Date;
            };

		

            // View.Add(calendarView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.     
		}

        partial void CalendarButton_TouchUpInside(UIButton sender)
        {

        }
    }
}