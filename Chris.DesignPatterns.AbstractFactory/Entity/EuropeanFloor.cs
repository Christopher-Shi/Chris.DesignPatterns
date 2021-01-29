using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 欧式地板类
    /// </summary>
    public class EuropeanFloor : Floor
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的地板");
        }
    }
}