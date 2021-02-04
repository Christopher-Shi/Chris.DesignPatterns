using Chris.DesignPatterns.Strategy.Strategy;

namespace Chris.DesignPatterns.Strategy
{
    /// <summary>
    /// 环境角色---相当于Context类型
    /// </summary>
    public sealed class SalaryContext
    {
        private ISalaryStrategy _strategy;

        public SalaryContext(ISalaryStrategy strategy)
        {
            _strategy = strategy;
        }

        public ISalaryStrategy ISalaryStrategy
        {
            get { return _strategy; }
            set
            { _strategy = value; }
        }

        public void GetSalary(double income)
        {
            _strategy.CalculateSalary(income);
        }
    }
}