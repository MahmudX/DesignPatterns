namespace SubjectSubscriber
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
        void SetValue(int value);
    }
}