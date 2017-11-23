using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace NewSoufanWeatherStation.iOS.Helper
{
    public class FilterObject
    {
        public FilteredData Data { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
