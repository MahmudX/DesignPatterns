namespace WeatherStation
{
    public interface IObserver
    {
        void Update(WeatherData data);
    }
}