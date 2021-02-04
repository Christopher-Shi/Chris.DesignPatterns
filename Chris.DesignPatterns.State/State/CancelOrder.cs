namespace Chris.DesignPatterns.State.State
{
    /// <summary>
    /// 取消订单---相当于具体状态角色
    /// </summary>
    public sealed class CancelOrder : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，有问题，取消订单！");
            order.TaskFinished = true;
        }
    }
}