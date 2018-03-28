using FactoryPattern.Factories;
using FactoryPattern.Pizzas;

namespace FactoryPattern.Store
{
    public class NYPizzaStore : PizzaStore
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public NYPizzaStore()
        {
            _pizzaIngredientFactory = new NYPizzaIngredientFactory();
        }
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(_pizzaIngredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }

            return pizza;
        }
    }
}
