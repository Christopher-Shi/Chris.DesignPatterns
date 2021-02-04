using System;

namespace Chris.DesignPatterns.Strategy.Strategy
{
    /// <summary>
    /// 程序员的工资--相当于具体策略角色ConcreteStrategyA
    /// </summary>
    public sealed class ProgrammerSalary : ISalaryStrategy
    {
        public void CalculateSalary(double income)
        {
            Console.WriteLine("我的工资是：基本工资(" + income + ")底薪(" + 8000 + ")+加班费+项目奖金（10%）");
        }
    }
}