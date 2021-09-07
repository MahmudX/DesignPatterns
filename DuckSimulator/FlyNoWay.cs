using System;

namespace DuckSimulator
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void DoFly()
        {
            Console.WriteLine("The duck can't fly.");
        }
    }
}