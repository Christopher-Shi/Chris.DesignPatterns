namespace Chris.DesignPatterns.AbstractFactory.AbstractEntity
{
    /// <summary>
    /// 房门抽象类，子类的房门必须继承该类
    /// </summary>
    public abstract class Door
    {
        /// <summary>
        /// 创建房门
        /// </summary>
        public abstract void Create();
    }
}