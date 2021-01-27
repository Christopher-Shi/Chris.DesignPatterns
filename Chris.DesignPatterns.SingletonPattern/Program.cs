using System;

namespace Chris.DesignPatterns.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.GetInstance();

            var singletonOne = SingletonOne.instance;

            var singletonTwo = SingletonTwo.instance;

            var multiThreadSingleton = MultiThreadSingleton.GetInstance();


            Console.WriteLine("Hello World!");
        }
    }
}
