using System;

namespace Chris.DesignPatterns.Template
{
    /// <summary>
    /// 模板方法模式（Template Method）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //现在想吃绿色面的，猪肉大葱馅的饺子
            AbstractClass fan = new ConcreteClass();
            fan.EatDumplings();

            Console.WriteLine();

            //过了段时间，我开始想吃橙色面的，韭菜鸡蛋馅的饺子
            fan = new ConcreteClass2();
            fan.EatDumplings();

            Console.ReadLine();
        }
    }
}
