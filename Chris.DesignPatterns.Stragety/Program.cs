using System;
using Chris.DesignPatterns.Strategy.Strategy;

namespace Chris.DesignPatterns.Strategy
{
    /// <summary>
    /// 策略模式（Strategy Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //普通员工的工资
            var context = new SalaryContext(new NormalPeopleSalary());
            context.GetSalary(3000);

            //CEO的工资
            context.ISalaryStrategy = new CEOSalary();
            context.GetSalary(6000);

            Console.ReadLine();
        }
    }
}
