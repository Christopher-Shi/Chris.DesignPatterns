using System;
using Chris.DesignPatterns.Visitor.Visitor;

namespace Chris.DesignPatterns.Visitor.Element
{
    /// <summary>
    /// 圆形---相当于“具体节点角色”ConcreteElement
    /// </summary>
    public sealed class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("圆形我已经画好！");
        }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}