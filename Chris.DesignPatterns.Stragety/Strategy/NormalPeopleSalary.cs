using System;

namespace Chris.DesignPatterns.Strategy.Strategy
{
    /// <summary>
    /// 普通员工的工资---相当于具体策略角色ConcreteStrategyB
    /// </summary>
    public sealed class NormalPeopleSalary : ISalaryStrategy
    {
        public void CalculateSalary(double income)
        {
            Console.WriteLine("我的工资是：基本工资(" + income + ")底薪(3000)+加班费");
        }
    }
}