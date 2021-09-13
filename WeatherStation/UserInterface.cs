using System;

namespace WeatherStation
{
    public class UserInterface : IObserver
    {
        private WeatherData data;
        public UserInterface(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Update(WeatherData weather)
        {
            data = weather;
        }

        public void Display()
        {
            Console.WriteLine("This is a ui -");
            Console.WriteLine("Temperature = " + data.Temperature + " °F");
            Console.WriteLine("Wind Speed = " + data.WindSpeed + " km/h");
            Console.WriteLine("Pressure = " + data.Pressure + " Pa\n");
        }
    }
}