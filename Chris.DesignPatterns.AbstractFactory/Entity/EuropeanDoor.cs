using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 欧式的房门
    /// </summary>
    public class EuropeanDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的房门");
        }
    }
}