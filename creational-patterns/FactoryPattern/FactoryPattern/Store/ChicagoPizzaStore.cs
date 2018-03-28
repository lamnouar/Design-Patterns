using FactoryPattern.Factories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;

        public ChicagoPizzaStore()
        {
            _pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        }
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(_pizzaIngredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }

            return pizza;
        }

    }
}
