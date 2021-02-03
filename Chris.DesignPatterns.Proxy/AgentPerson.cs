using System;

namespace Chris.DesignPatterns.Proxy
{
    /// <summary>
    /// 该类型是代理类型----相当于具体的Proxy角色
    /// </summary>
    public sealed class AgentPerson : AgentAbstract
    {
        //这是背后的老板，
        private FanStar boss;

        /// <summary>
        /// 老板在后面发号施令
        /// </summary>
        public AgentPerson()
        {
            boss = new FanStar();
        }

        /// <summary>
        /// 炒作的方法，执行具体的炒作---就是Proxy类型的Request方法
        /// </summary>
        /// <param name="thing"></param>
        public override void Speculation(string thing)
        {
            Console.WriteLine("前期弄点绯闻，拍点野照");
            base.Speculation(thing);
            Console.WriteLine("然后开发布会，伤心哭泣，继续捞钱");
        }
    }
}