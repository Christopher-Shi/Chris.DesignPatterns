namespace Chris.DesignPatterns.AbstractFactory.AbstractEntity
{
    /// <summary>
    /// 地板抽象类，子类的地板必须继承该类
    /// </summary>
    public abstract class Floor
    {
        /// <summary>
        /// 创建地板
        /// </summary>
        public abstract void Create();
    }
}