using Chris.DesignPatterns.State.State;

namespace Chris.DesignPatterns.State
{
    /// <summary>
    /// 环境角色---相当于Context类型
    /// </summary>
    public sealed class Order
    {
        private State.State current;

        public Order()
        {
            //工作状态初始化为尚无的工作状态，等待接单中
            current = new WaitForAcceptance();
            IsCancel = false;
        }
        private double minute;
        public double Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public bool IsCancel { get; set; }

        private bool finish;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }
        public void SetState(State.State s)
        {
            current = s;
        }
        public void Action()
        {
            current.Process(this);
        }
    }
}