using System;

namespace StrategyPattern.Models
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
