namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// 该抽象类就是实现接口的定义，该类型就相当于是Implementor类型
    /// </summary>
    public abstract class PlatformImplementor
    {
        /// <summary>
        /// 该方法就相当于Implementor类型的OperationImpl方法
        /// </summary>
        public abstract void Process();
    }
}