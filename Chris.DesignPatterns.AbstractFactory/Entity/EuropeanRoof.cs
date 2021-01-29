using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 欧式的房顶
    /// </summary>
    public class EuropeanRoof : Roof
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的房顶");
        }
    }
}