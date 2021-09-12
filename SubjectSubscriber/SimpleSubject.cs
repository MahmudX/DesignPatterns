using System.Collections.Generic;

namespace SubjectSubscriber
{
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
}