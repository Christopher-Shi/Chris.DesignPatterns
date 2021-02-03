namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// SqlServer2000版本的数据库，相当于RefinedAbstraction类型
    /// </summary>
    public class SqlServer2000 : Database
    {
        //构造函数初始化
        public SqlServer2000(PlatformImplementor implementor) : base(implementor)
        {

        }

        public override void Create()
        {
            _implementor.Process();
        }
    }
}