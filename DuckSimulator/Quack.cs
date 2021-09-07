using System;

namespace DuckSimulator
{
    public class Quack : IVerbalMethod
    {
        public void DoSound()
        {
            Console.WriteLine("Quack Quack!!!");
        }
    }
}