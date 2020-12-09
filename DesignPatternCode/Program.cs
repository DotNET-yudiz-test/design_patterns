using DoFactory.GangOfFour.Abstract.RealWorld;
using DoFactory.GangOfFour.Facade.RealWorld;
using DoFactory.GangOfFour.Prototype.RealWorld;
using DoFactory.GangOfFour.Singleton.RealWorld;
using System;
using System.Collections.Generic;
using static DesignPatternCode.Builder.Builder;

namespace DesignPatternCode
{
    internal class Program
    {
        //test commit
        private static void Main(string[] args)
        {
            //AbstractFactory
            //Provide an interface for creating related objects without specifying their concrete classes.

            AfricaFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            AmericaFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.WriteLine("\n");

            //=============================================================================================================================================================

            //Singleton
            //Ensure a class has only one instance and provide a global point of access to it.

            Singleton fromPrincipal = Singleton.GetInstance;
            fromPrincipal.PrintDetails("From Principal");
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

            Singleton oSingleton_1 = new Singleton();
            Singleton oSingleton_2 = new Singleton();

            Console.WriteLine("\n");

            //=============================================================================================================================================================

            //ProtoType
            //The intent behind the usage of a Prototype pattern is for creation of an object clone;
            //in other words it allows us to create a new instance by copying existing instances.

            var dev = new Developer
            {
                FirstName = "Gary",
                Lastname = "Woodfine",
                Skills = new List<string> { "C#", "PHP", "SQL", "JavaScript" }
            };

            var dev2 = dev.Clone() as Developer;

            Console.WriteLine($"The Cloned  Developer name is { dev2.FirstName }  { dev2.Lastname }");

            Console.WriteLine("The second developer has the following skills: ");

            foreach (var skill in dev2.Skills)
            {
                Console.WriteLine(skill);
            }

            Console.WriteLine("\n");

            //=============================================================================================================================================================

            // Facade
            //Provide a unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.

            Order order = new Order();
            order.PlaceOrder();

            Console.WriteLine("\n");

            //==============================================================================================================================================================

            // Builder
            //Builder is a creational design pattern that lets you construct complex objects step by step.

            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuider tea = new TeaBuider();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
            Console.Read();
        }
    }
}