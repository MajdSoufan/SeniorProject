﻿using System;
using SQLite;

namespace NewSoufanWeatherStation.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

    }
}
