using AdapterPattern.Adapter;
using AdapterPattern.Ducks;
using AdapterPattern.Turkey;
using System;

namespace AdapterPattern
{
    public class DuckTestDrive
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            Console.WriteLine("The turkey says :");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("The duck says");
            duck.Quack();
            duck.Fly();

            TurkeyAdapter adapter = new TurkeyAdapter(turkey);
            adapter.Quack();
            adapter.Fly();
        }
    }
}
