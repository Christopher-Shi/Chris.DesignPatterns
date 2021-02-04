namespace Chris.DesignPatterns.State.State
{
    /// <summary>
    /// //抽象状态角色---相当于State类型
    /// </summary>
    public interface State
    {
        /// <summary>
        /// 处理订单
        /// </summary>
        /// <param name="order"></param>
        void Process(Order order);
    }
}