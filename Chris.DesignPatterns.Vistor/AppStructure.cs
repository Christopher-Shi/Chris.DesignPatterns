using Chris.DesignPatterns.Visitor.Element;
using Chris.DesignPatterns.Visitor.Visitor;

namespace Chris.DesignPatterns.Visitor
{
    /// <summary>
    /// 结构对象角色
    /// </summary>
    internal class AppStructure
    {
        private ShapeVisitor _visitor;

        public AppStructure(ShapeVisitor visitor)
        {
            _visitor = visitor;
        }

        public void Process(Shape shape)
        {
            shape.Accept(_visitor);
        }
    }
}