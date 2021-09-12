using System;

namespace DroneAsDuck
{
    
    public class Drone : IDrone
    {
        public void SpinRotors()
        {
            Console.WriteLine("Rotors are spinning.");
        }
        public void TakeOff()
        {
            Console.WriteLine("Taking off!");
        }
        public void Beep()
        {
            Console.WriteLine("Beep beep beep.");
        }
    }
}