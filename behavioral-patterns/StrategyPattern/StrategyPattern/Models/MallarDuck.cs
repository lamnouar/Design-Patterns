using System;

namespace StrategyPattern.Models
{
    public class MallarDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallar duck");
        }
    }
}
