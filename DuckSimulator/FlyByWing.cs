using System;

namespace DuckSimulator
{
    public class FlyByWing : IFlyBehaviour
    {
        public void DoFly()
        {
            Console.WriteLine("The duck is flying.");
        }
    }
}