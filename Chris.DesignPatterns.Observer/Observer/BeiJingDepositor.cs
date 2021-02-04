using System;
using System.Globalization;

namespace Chris.DesignPatterns.Observer.Observer
{
    /// <summary>
    /// 北京的具体储户--相当于具体观察者角色ConcreteObserver
    /// </summary>
    public sealed class BeiJingDepositor : Depositor
    {
        public BeiJingDepositor(string name, int total) : base(name, total) { }

        public override void Update(int currentBalance, DateTime dateTime)
        {
            Console.WriteLine(Name + ":账户发生了变化，变化时间是" + dateTime.ToString(CultureInfo.InvariantCulture) + ",当前余额是" +
                              currentBalance);
        }
    }
}