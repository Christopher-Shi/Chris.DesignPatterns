using System;

namespace Chris.DesignPatterns.ChainOfResponsibility.Handler
{
    /// <summary>
    /// 部门经理----相当于“具体处理者角色” ConcreteHandler
    /// </summary>
    public sealed class Manager : Approver
    {
        public Manager(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount <= 10000.0)
            {
                Console.WriteLine("{0} 部门经理批准了对原材料{1}的采购计划！", Name, request.ProductName);
            }
            else
            {
                NextApprover?.ProcessRequest(request);
            }
        }
    }
}