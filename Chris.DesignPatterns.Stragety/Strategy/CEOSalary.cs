using System;

namespace Chris.DesignPatterns.Strategy.Strategy
{
    /// <summary>
    /// CEO的工资---相当于具体策略角色ConcreteStrategyC
    /// </summary>
    public sealed class CEOSalary : ISalaryStrategy
    {
        public void CalculateSalary(double income)
        {
            Console.WriteLine("我的工资是：基本工资(" + income + ")底薪(20000)+项目奖金(20%)+公司股票");
        }
    }
}