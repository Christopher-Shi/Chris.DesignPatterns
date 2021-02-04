using System;

namespace Chris.DesignPatterns.ChainOfResponsibility.Handler
{
    /// <summary>
    /// 财务经理---相当于“具体处理者角色”ConcreteHandler
    /// </summary>
    public sealed class FinancialManager : Approver
    {
        public FinancialManager(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount > 10000.0 && request.Amount <= 50000.0)
            {
                Console.WriteLine("{0} 财务经理批准了对原材料{1}的采购计划！", this.Name, request.ProductName);
            }
            else
            {
                NextApprover?.ProcessRequest(request);
            }
        }
    }
}