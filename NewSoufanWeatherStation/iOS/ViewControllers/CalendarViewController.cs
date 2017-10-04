using Foundation;
using System;
using UIKit;
using TimesSquare.iOS;

namespace NewSoufanWeatherStation.iOS
{
    public partial class CalendarViewController : UIViewController
    {
        public CalendarViewController (IntPtr handle) : base (handle)
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

            calendarView.DidSelectDate += (sender, e) => 
            {
                Model.UserData.BirthDate = (DateTime)e.Date;
            };

			View.Add(calendarView);
		}
    }
}