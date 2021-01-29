using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 现代的地板
    /// </summary>
    public class ModernizationFloor : Floor
    {
        public override void Create()
        {
            Console.WriteLine("创建现代的地板");
        }
    }
}