using System;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    //Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Buffalo();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Rabbits();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    abstract class Herbivore
    {
    }

    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    class Buffalo : Herbivore
    {
    }

    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class Rabbits : Herbivore
    {
    }

    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}