using System;

namespace DuckAdapterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            TestDuck(mallardDuck);

            Turkey turkey = new Turkey();
            var adapter = new TurkeyAdapter(turkey);
            TestDuck(adapter);
        }

        public static void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
