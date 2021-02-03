using System;
using Chris.DesignPatterns.Facade.System;

namespace Chris.DesignPatterns.Facade
{
    /// <summary>
    /// 更高层的Facade
    /// </summary>
    public class SystemFacade
    {
        private readonly AuthoriationSystemA _auth;
        private readonly SecuritySystemB _security;
        private readonly NetBankSystemC _netbank;

        public SystemFacade()
        {
            _auth = new AuthoriationSystemA();
            _security = new SecuritySystemB();
            _netbank = new NetBankSystemC();
        }

        public void Buy()
        {
            _auth.MethodA();//身份认证子系统
            _security.MethodB();//系统安全子系统
            _netbank.MethodC();//网银安全子系统

            Console.WriteLine("我已经成功购买了！");
        }
    }
}