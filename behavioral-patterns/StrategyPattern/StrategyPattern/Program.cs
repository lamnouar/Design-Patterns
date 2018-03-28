using StrategyPattern.Behaviors;
using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallarDuck = new MallarDuck();
            mallarDuck.SetFlyBehavior(new FlyNoWay());

            mallarDuck.Display();
            mallarDuck.PerformFly();
            mallarDuck.SetFlyBehavior(new FlyWithWings());
            mallarDuck.PerformFly();
            Console.ReadLine();
        }
    }
}
