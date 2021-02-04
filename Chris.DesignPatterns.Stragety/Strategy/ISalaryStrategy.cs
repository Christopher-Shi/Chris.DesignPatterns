namespace Chris.DesignPatterns.Strategy.Strategy
{
    /// <summary>
    /// 抽象策略角色---相当于Strategy类型
    /// </summary>
    public interface ISalaryStrategy
    {
        /// <summary>
        /// 工资计算
        /// </summary>
        /// <param name="income"></param>
        void CalculateSalary(double income);
    }
}