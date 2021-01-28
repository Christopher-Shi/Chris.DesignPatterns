using System;

namespace Chris.DesignPatterns.Factory.Car
{
    /// <summary>
    /// 红旗汽车
    /// </summary>
    public class HongQiCar : Car
    {
        public override void Go()
        {
            Console.WriteLine("红旗汽车开始行驶了！");
        }
    }
}