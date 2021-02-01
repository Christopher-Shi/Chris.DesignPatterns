using System;
using Chris.DesignPatterns.Factory.Factory;

namespace Chris.DesignPatterns.Factory
{
    /// <summary>
    /// 工厂方法模式（Factory Pattern）【创建型】
    /// 客户端调用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化创建汽车的两个工厂
            Factory.Factory hongQiCarFactory = new HongQiCarFactory();
            Factory.Factory aoDiCarFactory = new AoDiCarFactory();

            // 生产一辆红旗汽车
            var hongQi = hongQiCarFactory.CreateCar();
            hongQi.Go();

            //生产一辆奥迪汽车
            var aoDi = aoDiCarFactory.CreateCar();
            aoDi.Go();

            Console.Read();
        }
    }
}