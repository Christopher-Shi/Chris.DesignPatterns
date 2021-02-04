using Chris.DesignPatterns.Mediator.Department;
using Microsoft.VisualBasic;
using Financial = Chris.DesignPatterns.Mediator.Department.Financial;

namespace Chris.DesignPatterns.Mediator
{
    /// <summary>
    /// 总经理--相当于具体中介者角色
    /// </summary>
    public sealed class President : Mediator
    {
        //总经理有各个部门的管理权限
        private Financial _financial;
        private Market _market;
        private Development _development;

        public void SetFinancial(Financial financial)
        {
            _financial = financial;
        }

        public void SetDevelopment(Development development)
        {
            _development = development;
        }

        public void SetMarket(Market market)
        {
            _market = market;
        }

        public void Command(Department.Department department)
        {
            if (department is Market)
            {
                _financial.Process();
            }
        }
    }
}