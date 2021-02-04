using Chris.DesignPatterns.Visitor.Element;

namespace Chris.DesignPatterns.Visitor.Visitor
{
    /// <summary>
    /// 抽象访问者 Visitor
    /// </summary>
    public abstract class ShapeVisitor
    {
        public abstract void Visit(Rectangle shape);

        public abstract void Visit(Circle shape);

        public abstract void Visit(Line shape);

        //这里有一点要说：Visit方法的参数可以写成Shape吗？就是这样 Visit(Shape shape)，当然可以，但是ShapeVisitor子类Visit方法就需要判断当前的Shape是什么类型，是Rectangle类型，是Circle类型，或者是Line类型。
    }
}