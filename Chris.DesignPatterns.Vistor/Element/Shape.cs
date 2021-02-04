using Chris.DesignPatterns.Visitor.Visitor;

namespace Chris.DesignPatterns.Visitor.Element
{
    /// <summary>
    /// 抽象图形定义---相当于“抽象节点角色”Element
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// 画图形
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// 外界注入具体访问者
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(ShapeVisitor visitor);
    }
}