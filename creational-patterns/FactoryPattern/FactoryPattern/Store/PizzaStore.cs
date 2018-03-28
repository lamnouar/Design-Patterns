using FactoryPattern.Factories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Store
{
    public abstract class PizzaStore
    {
        //The Factory Method
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
