using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 现代的房门
    /// </summary>
    public class ModernizationDoor : Door
    {
        public override void Create()
        {
            Console.WriteLine("创建现代的房门");
        }
    }
}