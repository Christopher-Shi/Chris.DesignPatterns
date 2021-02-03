using System;

namespace Chris.DesignPatterns.Proxy
{
    /// <summary>
    /// 该类型是Fan姓明星，有钱有势，想炒什么炒什么---相当于具体的RealSubject角色
    /// </summary>
    public sealed class FanStar : AgentAbstract
    {
        /// <summary>
        /// 有钱有势，有背景啊
        /// </summary>
        public FanStar()
        {

        }

        /// <summary>
        /// 要有名气，定期要炒作---就是RealSubject类型的Request方法
        /// </summary>
        /// <param name="thing"></param>
        public override void Speculation(string thing)
        {
            Console.WriteLine(thing);
        }
    }
}