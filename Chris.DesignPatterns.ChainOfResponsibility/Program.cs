using System;
using Chris.DesignPatterns.ChainOfResponsibility.Handler;

namespace Chris.DesignPatterns.ChainOfResponsibility
{
    /// <summary>
    /// 责任链模式（Chain of Responsibility Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var requestDao = new PurchaseRequest(8000.0, "单刀5把");
            var requestHuaJi = new PurchaseRequest(10000.0, "10把方天画戟");
            var requestJian = new PurchaseRequest(80000.0, "5把金丝龙鳞闪电劈");

            Approver manager = new Manager("黄飞鸿");
            Approver financial = new FinancialManager("黄麒英");
            Approver ceo = new CEO("十三姨");

            // 设置职责链
            manager.NextApprover = financial;
            financial.NextApprover = ceo;

            // 处理请求
            manager.ProcessRequest(requestDao);
            manager.ProcessRequest(requestHuaJi);
            manager.ProcessRequest(requestJian);

            Console.ReadLine();
        }
    }
}
