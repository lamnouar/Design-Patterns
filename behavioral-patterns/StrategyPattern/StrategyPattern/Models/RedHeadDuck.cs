using System;

namespace StrategyPattern.Models
{
    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a red head duck");
        }
    }
}
