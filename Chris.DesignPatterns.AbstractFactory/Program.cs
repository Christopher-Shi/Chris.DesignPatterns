using System;
using Chris.DesignPatterns.AbstractFactory.Factory;

namespace Chris.DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 下面以不同系列房屋的建造为例子演示抽象工厂模式
    /// 因为每个人的喜好不一样，我喜欢欧式的，我弟弟就喜欢现代的
    /// 客户端调用
    /// </summary>
    class Program
    {
        static void Main()
        {
            // 哥哥的欧式风格的房子
            var europeanFactory = new EuropeanFactory();
            europeanFactory.CreateRoof().Create();
            europeanFactory.CreateFloor().Create();
            europeanFactory.CreateWindow().Create();
            europeanFactory.CreateDoor().Create();


            //弟弟的现代风格的房子
            var modernizationFactory = new ModernizationFactory();
            modernizationFactory.CreateRoof().Create();
            modernizationFactory.CreateFloor().Create();
            modernizationFactory.CreateWindow().Create();
            modernizationFactory.CreateDoor().Create();

            //古典风格的房子
            var classicalFactory = new ClassicalFactory();
            classicalFactory.CreateRoof().Create();
            classicalFactory.CreateFloor().Create();
            classicalFactory.CreateWindow().Create();
            classicalFactory.CreateDoor().Create();

            Console.ReadLine();
        }
    }
}
