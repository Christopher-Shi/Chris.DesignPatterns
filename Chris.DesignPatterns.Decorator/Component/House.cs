namespace Chris.DesignPatterns.Decorator.Component
{
    /// <summary>
    /// 该抽象类就是房子抽象接口的定义，该类型就相当于是Component类型，是饺子馅，需要装饰的，需要包装的
    /// </summary>
    public abstract class House
    {
        /// <summary>
        /// 房子的装修方法--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Renovation();
    }
}