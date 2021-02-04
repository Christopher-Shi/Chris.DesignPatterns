using System;
using Chris.DesignPatterns.Observer.Observer;
using Chris.DesignPatterns.Observer.Subject;

namespace Chris.DesignPatterns.Observer
{
    /// <summary>
    /// 观察者模式（Observer Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //我们有了三位储户，都是武林高手，也比较有钱
            Depositor huangFeiHong = new BeiJingDepositor("黄飞鸿", 3000);
            Depositor fangShiYu = new BeiJingDepositor("方世玉", 1300);
            Depositor hongXiGuan = new BeiJingDepositor("洪熙官", 2500);

            BankMessageSystem beijingBank = new BeiJingBankMessageSystem();
            //这三位开始订阅银行短信业务
            beijingBank.Add(huangFeiHong);
            beijingBank.Add(fangShiYu);
            beijingBank.Add(hongXiGuan);

            //黄飞鸿取100块钱
            huangFeiHong.GetMoney(100);
            beijingBank.Notify();

            //黄飞鸿和方世玉都取了钱
            huangFeiHong.GetMoney(200);
            fangShiYu.GetMoney(200);
            beijingBank.Notify();

            //他们三个都取了钱
            huangFeiHong.GetMoney(320);
            fangShiYu.GetMoney(4330);
            hongXiGuan.GetMoney(332);
            beijingBank.Notify();

            Console.ReadLine();
        }
    }
}
