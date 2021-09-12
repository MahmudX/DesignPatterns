using System;

namespace DroneAsDuck
{
    internal class Program
    {
        public static void Main()
        {
            var mallardDuck = new MallardDuck();
            TestDuck(mallardDuck);

            var drone = new Drone();
            var droneAdapter = new DroneAdapter(drone);
            TestDuck(droneAdapter);
        }

        public static void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
