namespace Chris.DesignPatterns.AbstractFactory.AbstractEntity
{
    /// <summary>
    /// 房顶抽象类，子类的房顶必须继承该类
    /// </summary>
    public abstract class Roof
    {
        /// <summary>
        /// 创建房顶
        /// </summary>
        public abstract void Create();
    }
}