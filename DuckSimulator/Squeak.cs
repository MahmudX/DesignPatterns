using System;

namespace DuckSimulator
{
    public class Squeak : IVerbalMethod
    {
        public void DoSound()
        {
            Console.WriteLine("Squeak Squeak!!!");
        }
    }
}