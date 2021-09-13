using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> observers;
        private WeatherData weatherData;

        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
                observer.Update(weatherData);
        }

        public void SetValue(string temp, float windSpeed, float pressure)
        {
            weatherData = new WeatherData
            {
                Temperature = temp, WindSpeed = windSpeed, Pressure = pressure
            };
            NotifyObserver();
        }
    }
}