using System;
using Chris.DesignPatterns.Mediator.Department;

namespace Chris.DesignPatterns.Mediator
{
    /// <summary>
    /// 中介者模式（Mediator Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new President();
            var market = new Market(mediator);
            var development = new Development(mediator);
            var financial = new Financial(mediator);

            mediator.SetFinancial(financial);
            mediator.SetDevelopment(development);
            mediator.SetMarket(market);

            market.Process();
            market.Apply();

            Console.ReadLine();
        }
    }
}
