using FactoryPattern.Ingredients;

namespace FactoryPattern.Factories
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory

    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new MushRoom(), new RedPepper() };
            return veggies;
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}