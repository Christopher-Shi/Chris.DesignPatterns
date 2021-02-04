using System;

namespace Chris.DesignPatterns.State
{
    /// <summary>
    /// 状态模式（State Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //订单
            var order = new Order {Minute = 9};
            order.Action();
            //可以取消订单
            order.IsCancel = true;
            order.Minute = 20;
            order.Action();
            order.Minute = 33;
            order.Action();
            order.Minute = 43;
            order.Action();

            Console.ReadLine();
        }
    }
}
