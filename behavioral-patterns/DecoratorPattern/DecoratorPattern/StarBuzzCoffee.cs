using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
   public class StarBuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            System.Console.WriteLine(espresso.GetDescription() + "   -   " + espresso.Cost());

            Beverage espressoMocha = new Mocha(espresso);
            System.Console.WriteLine(espressoMocha.GetDescription() + "   -   " + espressoMocha.Cost());

            System.Console.ReadLine();
        }
    }
}
