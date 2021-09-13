using System;

namespace WeatherStation
{
    public class Alert : IObserver
    {
        private WeatherData data;
        public Alert(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Update(WeatherData weather)
        {
            data = weather;
        }
        public void Message()
        {
            Console.WriteLine("This is a Alert -");
            Console.WriteLine("Temperature = " + data.Temperature + " °F");
            Console.WriteLine("Wind Speed = " + data.WindSpeed + " km/h");
            Console.WriteLine("Pressure = " + data.Pressure + " Pa\n");
        }
    }
}