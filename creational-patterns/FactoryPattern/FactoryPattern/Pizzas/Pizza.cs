using FactoryPattern.Ingredients;
using System;

namespace FactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Veggies[] Veggies { get; set; }
        protected Cheese Cheese { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clams Clam { get; set; }


        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Ctting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
