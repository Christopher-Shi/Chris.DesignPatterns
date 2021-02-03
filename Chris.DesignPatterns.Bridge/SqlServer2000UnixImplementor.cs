using System;

namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// SqlServer2000版本的数据库针对Unix操作系统具体的实现，相当于ConcreteImplementorA类型
    /// </summary>
    public class SqlServer2000UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2000针对Unix的具体实现");
        }
    }
}