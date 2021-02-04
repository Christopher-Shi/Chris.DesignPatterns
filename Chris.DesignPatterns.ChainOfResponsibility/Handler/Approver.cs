namespace Chris.DesignPatterns.ChainOfResponsibility.Handler
{
    /// <summary>
    /// 抽象审批人,Handler---相当于“抽象处理者角色”
    /// </summary>
    public abstract class Approver
    {
        /// <summary>
        /// 下一位审批人，由此形成一条链
        /// </summary>
        public Approver NextApprover { get; set; }

        /// <summary>
        /// 审批人的名称
        /// </summary>
        public string Name { get; set; }

        public Approver(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="request"></param>
        public abstract void ProcessRequest(PurchaseRequest request);
    }
}