using System;

namespace Chris.DesignPatterns.Proxy
{
    /// <summary>
    /// 代理模式（Proxy Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //近期，Fan姓明星关注度有点下降，来点炒作
            AgentAbstract fan = new AgentPerson();
            fan.Speculation("偶尔出来现现身，为炒作造势");

            Console.WriteLine();

            //过了段时间，又不行了，再炒作一次
            fan.Speculation("这段时间不火了，开始离婚炒作");

            Console.ReadLine();
        }
    }
}
