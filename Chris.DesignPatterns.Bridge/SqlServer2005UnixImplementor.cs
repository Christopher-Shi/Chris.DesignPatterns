using System;

namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// SqlServer2005版本的数据库针对Unix操作系统的具体实现，相当于ConcreteImplementorB类型
    /// </summary>
    public sealed class SqlServer2005UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2005针对Unix的具体实现");
        }
    }
}