using FactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory  = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
        }
    }
}
