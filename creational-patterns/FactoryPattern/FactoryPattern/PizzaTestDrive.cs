using FactoryPattern.Pizzas;
using FactoryPattern.Store;
using System;

namespace FactoryPattern
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Console.WriteLine("First Order :");
            Pizza pizza = nyStore.OrderPizza("cheese");

            //Console.WriteLine("Second Order :");
            //pizza = chicagoStore.OrderPizza("cheese");
        }
    }
}
