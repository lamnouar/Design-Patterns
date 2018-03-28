using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<Observer>();
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_temperature, _humidity, _pressure));
        }

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementChanged();
        }
    }
}
