using System.Collections.Generic;
using Chris.DesignPatterns.Observer.Observer;

namespace Chris.DesignPatterns.Observer.Subject
{
    /// <summary>
    /// 银行短信系统抽象接口，是被观察者--该类型相当于抽象主体角色Subject
    /// </summary>
    public abstract class BankMessageSystem
    {
        protected IList<Depositor> observers;

        //构造函数初始化观察者列表实例
        protected BankMessageSystem()
        {
            observers = new List<Depositor>();
        }

        /// <summary>
        /// 增加预约储户
        /// </summary>
        /// <param name="depositor"></param>
        public abstract void Add(Depositor depositor);

        /// <summary>
        /// 删除预约储户
        /// </summary>
        /// <param name="depositor"></param>
        public abstract void Delete(Depositor depositor);

        /// <summary>
        /// 通知储户
        /// </summary>
        public void Notify()
        {
            foreach (var depositor in observers)
            {
                if (depositor.AccountIsChanged)
                {
                    depositor.Update(depositor.Balance, depositor.OperationDateTime);
                    //账户发生了变化，并且通知了，储户的账户就认为没有变化
                    depositor.AccountIsChanged = false;
                }
            }
        }
    }
}