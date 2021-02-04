namespace Chris.DesignPatterns.Mediator.Department
{
    /// <summary>
    /// 同事类的接口
    /// </summary>
    public abstract class Department
    {
        /// <summary>
        /// 持有中介者(总经理)的引用
        /// </summary>
        private Mediator mediator;

        protected Department(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public Mediator GetMediator
        {
            get { return mediator; }
            private set
            {
                this.mediator = value;
            }
        }

        /// <summary>
        /// 做本部门的事情
        /// </summary>
        public abstract void Process();

        /// <summary>
        /// 向总经理发出申请
        /// </summary>
        public abstract void Apply();
    }
}