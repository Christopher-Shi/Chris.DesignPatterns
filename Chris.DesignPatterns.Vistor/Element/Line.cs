using System;
using Chris.DesignPatterns.Visitor.Visitor;

namespace Chris.DesignPatterns.Visitor.Element
{
    /// <summary>
    /// 直线---相当于“具体节点角色” ConcreteElement
    /// </summary>
    public sealed class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("直线我已经画好！");
        }

        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}