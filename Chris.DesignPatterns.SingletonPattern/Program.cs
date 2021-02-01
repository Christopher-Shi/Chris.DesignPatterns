using System;

namespace Chris.DesignPatterns.Singleton
{
    /// <summary>
    /// 单例模式（Singleton Pattern）【创建型】
    /// </summary>
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
