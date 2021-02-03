using System;

namespace Chris.DesignPatterns.Proxy
{
    /// <summary>
    /// 该类型就是抽象Subject角色，定义代理角色和真实主体角色共有的接口方法
    /// </summary>
    public abstract class AgentAbstract
    {
        /// <summary>
        /// 该方法执行具体的炒作---该方法相当于抽象Subject的Request方法
        /// </summary>
        /// <param name="thing"></param>
        public virtual void Speculation(string thing)
        {
            Console.WriteLine(thing);
        }
    }
}