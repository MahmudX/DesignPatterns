using System;
using System.Runtime.Intrinsics.Arm;

namespace DuckSimulator
{
    internal class Program
    {
        private static void Main()
        {
            RedHeadDuck redHeadDuck = new();
            redHeadDuck.PerformFly();
            redHeadDuck.PerformVerbalJob();
            redHeadDuck.Display();
            redHeadDuck.Swim();

            CombinedDuck henLike = new();
            henLike.PerformVerbalJob();

        }
    }

    public class HenSound : IVerbalMethod
    {
        public void DoSound()
        {
            Console.WriteLine("oo-oo");
        }
    }

    public class CombinedDuck : Duck
    {
        public CombinedDuck()
        {
            VerbalBehaviour = new HenSound();
            FlyBehaviour = new FlyByWing();
        }

        public override void Display()
        {
            Console.WriteLine("Hen like duck.");
        }
    }
}
