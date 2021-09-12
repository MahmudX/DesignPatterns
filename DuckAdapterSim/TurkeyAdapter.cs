namespace DuckAdapterSim
{
    public class TurkeyAdapter : IDuck
    {
        private readonly Turkey turkey;
        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            turkey.Fly();
        }
    }
}