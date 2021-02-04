using System;
using Chris.DesignPatterns.Visitor.Element;
using Chris.DesignPatterns.Visitor.Visitor;

namespace Chris.DesignPatterns.Visitor
{
    /// <summary>
    /// 访问者模式（Visitor Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //如果想执行新增加的操作
            ShapeVisitor visitor = new CustomVisitor();
            var app = new AppStructure(visitor);

            Shape shape = new Rectangle();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作


            shape = new Circle();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作


            shape = new Line();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作

            Console.ReadLine();
        }
    }
}
