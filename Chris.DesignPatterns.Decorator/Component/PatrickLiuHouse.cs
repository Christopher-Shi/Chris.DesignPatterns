using System;

namespace Chris.DesignPatterns.Decorator.Component
{
    /// <summary>
    /// PatrickLiu的房子，我要按我的要求做房子，相当于ConcreteComponent类型，这就是我们具体的饺子馅，我个人比较喜欢韭菜馅
    /// </summary>
    public sealed class PatrickLiuHouse : House
    {
        public override void Renovation()
        {
            Console.WriteLine("装修PatrickLiu的房子");
        }
    }
}