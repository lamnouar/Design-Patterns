using DecoratorPattern.Components;
namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}
