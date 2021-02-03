using System;
using Chris.DesignPatterns.Decorator.Component;

namespace Chris.DesignPatterns.Decorator.Decorator
{
    /// <summary>
    /// 具有安全功能的设备，可以提供监视和报警功能，相当于ConcreteDecoratorA类型
    /// </summary>
    public sealed class HouseSecurityDecorator : DecorationStrategy
    {
        public HouseSecurityDecorator(House house) : base(house)
        {

        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加安全系统");
        }
    }
}