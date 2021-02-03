using System;
using Chris.DesignPatterns.Decorator.Component;

namespace Chris.DesignPatterns.Decorator.Decorator
{
    /// <summary>
    /// 具有保温接口的材料，提供保温功能，相当于ConcreteDecoratorB类型
    /// </summary>
    public sealed class KeepWarmDecorator : DecorationStrategy
    {
        public KeepWarmDecorator(House house) : base(house)
        {

        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加保温的功能");
        }
    }
}