using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataSource
{
    public static class WeatherProvider
    {
        public static IEnumerable<Weather> GetWeather()
        {
            return new Weather[]
            {
                new Weather{City = "New Delhi", Country = "India", RainfallInInches = "22", Temperature = "40C"},
                new Weather{City = "Beijing", Country = "China", RainfallInInches = "52", Temperature = "20C"},
                new Weather{City = "Sydney", Country = "Australia", RainfallInInches = "29", Temperature = "10C"},
            };
        }
    }
}
