using System;
using Chris.DesignPatterns.Builder.Builder;

namespace Chris.DesignPatterns.Builder
{
    /// <summary>
    /// 现在人们的生活水平都提高了，有钱了，我今天就以汽车组装为例子
    /// 每台汽车的组装过程都是一致的，所以我们使用同样的构建过程可以创建不同的表示(即可以组装成不同型号的汽车)
    /// 组装汽车、电脑、手机、电视等等负责对象的这些场景都可以应用建造者模式来设计
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            Builder.Builder buickCarBuilder = new BuickBuilder();
            Builder.Builder aoDiCarBuilder = new AoDiBuilder();

            director.Construct(buickCarBuilder);

            //组装完成，我来驾驶别克了
            var buickCar = buickCarBuilder.GetCar();
            buickCar.Show();

            // 我老婆就要奥迪了，她比较喜欢大品牌
            director.Construct(aoDiCarBuilder);
            var aoDiCar = aoDiCarBuilder.GetCar();
            aoDiCar.Show();

            Console.ReadLine();
        }
    }
}
