using System;

namespace DuckSimulator
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            FlyBehaviour = new FlyByWing();
            VerbalBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("As the name implies, " +
                              "the duck's head is red.");
        }
    }
}