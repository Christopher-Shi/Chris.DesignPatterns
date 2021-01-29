using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    /// 现代的窗户
    /// </summary>
    public class ModernizationWindow : Window
    {
        public override void Create()
        {
            Console.WriteLine("创建现代的窗户");
        }
    }
}