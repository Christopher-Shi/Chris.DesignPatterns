using System;

namespace Chris.DesignPatterns.Flyweight.Weapen
{
    /// <summary>
    /// 此类型和享元没太大关系，可以算是享元对象的状态吧，需要从外部定义
    /// </summary>
    public sealed class AK47 : Weapen
    {
        public override void Fire(string jobName)
        {
            Console.WriteLine(jobName);
        }
    }
}