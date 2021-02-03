using System;
using Chris.DesignPatterns.Decorator.Component;
using Chris.DesignPatterns.Decorator.Decorator;

namespace Chris.DesignPatterns.Decorator
{
    /// <summary>
    /// 装饰模式（Decorator Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //这就是我们的饺子馅，需要装饰的房子
            House myselfHouse = new PatrickLiuHouse();

            DecorationStrategy securityHouse = new HouseSecurityDecorator(myselfHouse);
            securityHouse.Renovation();
            //房子就有了安全系统了

            //如果我既要安全系统又要保暖呢，继续装饰就行
            DecorationStrategy securityAndWarmHouse = new HouseSecurityDecorator(securityHouse);
            securityAndWarmHouse.Renovation();

            Console.ReadLine();
        }
    }
}
