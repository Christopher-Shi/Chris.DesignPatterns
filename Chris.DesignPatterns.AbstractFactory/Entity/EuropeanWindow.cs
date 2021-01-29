using System;
using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Entity
{
    /// <summary>
    ///欧式的窗户
    /// </summary>
    public class EuropeanWindow : Window
    {
        public override void Create()
        {
            Console.WriteLine("创建欧式的窗户");
        }
    }
}