using System;

namespace SubjectSubscriber
{
    public class SimpleObserver : IObserver
    {
        private int value;
        private readonly ISubject simpleSubject;

        public SimpleObserver(ISubject simpleSubject)
        {
            this.simpleSubject = simpleSubject;
            simpleSubject.RegisterObserver(this);
        }
        public void Update(int value)
        {
            this.value = value;
            
        }

        public void Display()
        {
            Console.WriteLine("Value: " + value);
        }
    }
}