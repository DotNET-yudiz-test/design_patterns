using System;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    //Provide an interface for creating families of related or dependent objects without specifying their concrete classes. test test
    internal abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();
    }

    internal class AfricaFactory : ContinentFactory
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

    internal class AmericaFactory : ContinentFactory
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

    internal abstract class Herbivore
    {
    }

    internal abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    internal class Buffalo : Herbivore
    {
    }

    internal class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    internal class Rabbits : Herbivore
    {
    }

    internal class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    internal class AnimalWorld
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
