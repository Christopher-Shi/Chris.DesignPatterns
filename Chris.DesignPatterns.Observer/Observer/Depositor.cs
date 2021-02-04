using System;

namespace Chris.DesignPatterns.Observer.Observer
{
    /// <summary>
    /// 储户的抽象接口--相当于抽象观察者角色（Observer）
    /// </summary>
    public abstract class Depositor
    {
        //状态数据
        private string _name;
        private int _balance;
        private int _total;
        private bool _isChanged;

        //初始化状态数据
        protected Depositor(string name, int total)
        {
            _name = name;
            _balance = total;//存款总额等于余额
            _isChanged = false;//账户未发生变化
        }

        //储户的名称，假设可以唯一区别的
        public string Name
        {
            get { return _name; }
            private set
            { _name = value; }
        }

        public int Balance
        {
            get { return _balance; }
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="num"></param>
        public void GetMoney(int num)
        {
            if (num <= _balance && num > 0)
            {
                _balance = _balance - num;
                _isChanged = true;
                OperationDateTime = DateTime.Now;
            }
        }

        //账户操作时间
        public DateTime OperationDateTime { get; set; }

        //账户是否发生变化
        public bool AccountIsChanged
        {
            get { return _isChanged; }
            set { _isChanged = value; }
        }

        //更新储户状态
        public abstract void Update(int currentBalance, DateTime dateTime);
    }
}