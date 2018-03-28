using System;

namespace StrategyPattern.Models
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
