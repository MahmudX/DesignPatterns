using System;

namespace DroneAsDuck
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Fly Mallard Fly");
        }
    }
}