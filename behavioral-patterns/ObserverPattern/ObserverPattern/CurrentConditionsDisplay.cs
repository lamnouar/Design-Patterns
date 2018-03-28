using System;
namespace ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private Subject _weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("The current conditions: Temperature(" + _temperature
                              + ") Humidity(" + _humidity + ") Pressure(" + _pressure + ")");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }
    }
}
