using System;
using Chris.DesignPatterns.Visitor.Element;

namespace Chris.DesignPatterns.Visitor.Visitor
{
    /// <summary>
    /// 具体访问者 ConcreteVisitor
    /// </summary>
    public sealed class CustomVisitor : ShapeVisitor
    {
        /// <summary>
        /// 针对Rectangle对象
        /// </summary>
        /// <param name="shape"></param>
        public override void Visit(Rectangle shape)
        {
            Console.WriteLine("针对Rectangle新的操作！");
        }

        /// <summary>
        /// 针对Circle对象
        /// </summary>
        /// <param name="shape"></param>
        public override void Visit(Circle shape)
        {
            Console.WriteLine("针对Circle新的操作！");
        }

        /// <summary>
        /// 针对Line对象
        /// </summary>
        /// <param name="shape"></param>
        public override void Visit(Line shape)
        {
            Console.WriteLine("针对Line新的操作！");
        }
    }
}