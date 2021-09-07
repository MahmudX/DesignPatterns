using System;

namespace DuckSimulator
{
    public abstract class Duck
    {
        protected IVerbalMethod VerbalBehaviour {  get; set; }
        protected IFlyBehaviour FlyBehaviour { private get; set; }

        public void PerformVerbalJob()
        {
            VerbalBehaviour.DoSound();
        }

        public void PerformFly()
        {
            FlyBehaviour.DoFly();
        }
        public void Swim()
        {
            Console.WriteLine("The duck is now swimming.");
        }
        public abstract void Display();
    }
}