namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// 该抽象类就是抽象接口的定义，该类型就相当于是Abstraction类型
    /// </summary>
    public abstract class Database
    {
        //通过组合方式引用平台接口，此处就是桥梁，该类型相当于Implementor类型
        protected PlatformImplementor _implementor;

        /// <summary>
        /// 通过构造器注入，初始化平台实现
        /// </summary>
        /// <param name="implementor"></param>
        protected Database(PlatformImplementor implementor)
        {
            _implementor = implementor;
        }

        /// <summary>
        /// 创建数据库--该操作相当于Abstraction类型的Operation方法
        /// </summary>
        public abstract void Create();
    }
}