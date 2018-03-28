using FactoryPattern.Ingredients;
using System;

namespace FactoryPattern.Factories
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Clams CreateClam()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
