using System;

namespace Chris.DesignPatterns.Facade
{
    /// <summary>
    /// 外观模式（Facade Pattern）
    /// 不使用外观模式的情况
    /// 此时客户端与三个子系统都发送了耦合，使得客户端程序依赖与子系统
    /// 为了解决这样的问题，我们可以使用外观模式来为所有子系统设计一个统一的接口
    /// 客户端只需要调用外观类中的方法就可以了，简化了客户端的操作
    /// 从而让客户和子系统之间避免了紧耦合
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new SystemFacade();
            facade.Buy();

            Console.ReadLine();
        }
    }
}
