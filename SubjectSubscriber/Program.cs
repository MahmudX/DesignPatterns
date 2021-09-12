namespace SubjectSubscriber
{
    internal static class Program
    {
        private static void Main()
        {
            var subject = new SimpleSubject();

            SimpleObserver simple = new(subject);
            subject.SetValue(5);

            simple.Display();

            SimpleObserver antherObserver = new(subject);
            subject.SetValue(10);

            antherObserver.Display();
            simple.Display();
        }
    }
}
