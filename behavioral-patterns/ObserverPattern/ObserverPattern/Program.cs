using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            Observer currentConditionsDiaplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(24, 65, 30);
            weatherData.SetMeasurements(40, 1, 20);

            Console.ReadLine();
        }
    }
}
