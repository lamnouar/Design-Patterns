using FactoryPattern.Factories;
using System;

namespace FactoryPattern.Pizzas
{
    public class ClamPizza : Pizza
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public ClamPizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Clam = _pizzaIngredientFactory.CreateClam();
        }
    }
}
