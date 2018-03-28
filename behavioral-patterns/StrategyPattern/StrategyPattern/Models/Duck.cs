using StrategyPattern.Behaviors;
using System;

namespace StrategyPattern.Models
{
    public abstract class Duck
    {
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
    }
}
