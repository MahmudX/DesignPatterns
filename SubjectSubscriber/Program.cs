using System;
using System.Collections.Generic;

namespace SubjectSubscriber
{
    internal static class Program
    {
        private static void Main()
        {
            var subject = new SimpleSubject();
            Console.WriteLine("Created Subject.\n");

            SimpleObserver simple = new(subject);
            Console.WriteLine("Created Simple Observer.\n");
            simple.Display();
            Console.WriteLine("Called Simple Observer's display.\n");
            simple.Update(5);
            Console.WriteLine("Updated Simple Observer.\n");
            simple.Display();
            Console.WriteLine("Called Simple Observer's display.\n");

            SimpleObserver antherObserver = new SimpleObserver(subject);
            Console.WriteLine("Created Another Observer.\n");

            antherObserver.Display();
            Console.WriteLine("Called Another Observer's display.\n");

            antherObserver.Update(10);
            Console.WriteLine("Updated Another Observer.\n");
            antherObserver.Display();
            Console.WriteLine("Called Another Observer's display.\n");
            simple.Display();
            Console.WriteLine("Called Simple Observer's display.\n");
        }
    }

    public interface IObserver
    {
        void Update(int value);
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }

    public class SimpleSubject : ISubject
    {
        private readonly List<IObserver> observers;
        private int value = 0;
        public SimpleSubject()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(value);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetValue(int newValue)
        {
            value = newValue;
            NotifyObserver();
        }
    }

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
