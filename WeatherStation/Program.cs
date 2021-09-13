namespace WeatherStation
{
    internal static class Program
    {
        private static void Main()
        {
            var weatherStation = new WeatherStation();
            var userInterface = new UserInterface(weatherStation);
            var logger = new Logger(weatherStation);
            var alert = new Alert(weatherStation);
            weatherStation.SetValue("Hot", 122f, 32.5f);
            userInterface.Display();
            alert.Message();
            logger.Log();
        }
    }
}
