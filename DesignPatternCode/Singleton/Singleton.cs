using System;

namespace DoFactory.GangOfFour.Singleton.RealWorld
{
    //Ensure a class has only one instance and provide a global point of access to it.
    public class Singleton
    {
        private static Singleton instance = null;

        public Singleton()
        {
            Console.WriteLine("New Object");
        }

        //Methods
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}