using System;

namespace Chris.DesignPatterns.Factory.Car
{
    /// <summary>
    /// 奥迪汽车
    /// </summary>
    public class AoDiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("奥迪汽车开始行驶了！");
        }
    }
}