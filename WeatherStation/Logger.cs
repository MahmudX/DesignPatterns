using System;

namespace WeatherStation
{
    public class Logger : IObserver
    {
        private WeatherData data;
        public Logger(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Update(WeatherData weather)
        {
            data = weather;
        }
        public void Log()
        {
            Console.WriteLine("This is a logger -");
            Console.WriteLine("Temperature = " + data.Temperature + " °F");
            Console.WriteLine("Wind Speed = " + data.WindSpeed + " km/h");
            Console.WriteLine("Pressure = " + data.Pressure + " Pa\n");
        }
    }
}