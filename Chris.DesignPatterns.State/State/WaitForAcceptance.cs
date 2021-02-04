namespace Chris.DesignPatterns.State.State
{
    /// <summary>
    /// 等待受理--相当于具体状态角色
    /// </summary>
    public sealed class WaitForAcceptance : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("我们开始受理，准备备货！");
            if (order.Minute < 30 && order.IsCancel)
            {
                System.Console.WriteLine("接受半个小时之内，可以取消订单！");
                order.SetState(new CancelOrder());
                order.Action();
            }
            order.SetState(new AcceptAndDeliver());
            order.TaskFinished = false;
            order.Action();
        }
    }
}