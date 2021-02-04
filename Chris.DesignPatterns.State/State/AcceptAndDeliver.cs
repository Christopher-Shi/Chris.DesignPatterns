namespace Chris.DesignPatterns.State.State
{
    /// <summary>
    /// 受理发货---相当于具体状态角色
    /// </summary>
    public sealed class AcceptAndDeliver : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("我们货物已经准备好，可以发货了，不可以撤销订单！");
            if (order.Minute < 30 && order.IsCancel)
            {
                System.Console.WriteLine("接受半个小时之内，可以取消订单！");
                order.SetState(new CancelOrder());
                order.Action();
            }
            if (order.TaskFinished == false)
            {
                order.SetState(new ConfirmationReceipt());
                order.Action();
            }
        }
    }
}