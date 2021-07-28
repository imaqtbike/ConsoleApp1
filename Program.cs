using System;
using MyUtilities; 


namespace ConsoleApp1
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should I go in May ?");
            WeatherUtilities.Report("San Fran", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 73);
            WeatherUtilities.Report("Bologna", 23, 65);
        }
    }
}