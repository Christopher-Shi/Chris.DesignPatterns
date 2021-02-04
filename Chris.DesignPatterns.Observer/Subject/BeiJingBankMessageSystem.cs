using Chris.DesignPatterns.Observer.Observer;

namespace Chris.DesignPatterns.Observer.Subject
{
    /// <summary>
    /// 北京银行短信系统，是被观察者--该类型相当于具体主体角色ConcreteSubject
    /// </summary>
    public sealed class BeiJingBankMessageSystem : BankMessageSystem
    {
        /// <summary>
        /// 增加预约储户
        /// </summary>
        /// <param name="depositor"></param>
        public override void Add(Depositor depositor)
        {
            //应该先判断该用户是否存在，存在不操作，不存在则增加到储户列表中，这里简化了
            observers.Add(depositor);
        }

        /// <summary>
        /// 删除预约储户
        /// </summary>
        /// <param name="depositor"></param>
        public override void Delete(Depositor depositor)
        {
            //应该先判断该用户是否存在，存在则删除，不存在无操作，这里简化了
            observers.Remove(depositor);
        }
    }
}