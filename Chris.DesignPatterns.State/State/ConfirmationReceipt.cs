namespace Chris.DesignPatterns.State.State
{
    /// <summary>
    /// 确认收货---相当于具体状态角色
    /// </summary>
    public sealed class ConfirmationReceipt : State
    {
        public void Process(Order order)
        {
            System.Console.WriteLine("检查货物，没问题可以就可以签收！");
            order.SetState(new Success());
            order.TaskFinished = false;
            order.Action();
        }
    }
}