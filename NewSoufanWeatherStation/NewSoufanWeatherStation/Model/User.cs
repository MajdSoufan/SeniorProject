using System;
using SQLite;
using System.Collections.Generic;

namespace NewSoufanWeatherStation.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        //public List<Model.WeatherStation> StationsList { get; set; }
    }
}

