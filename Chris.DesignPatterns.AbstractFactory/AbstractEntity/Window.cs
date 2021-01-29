namespace Chris.DesignPatterns.AbstractFactory.AbstractEntity
{
    /// <summary>
    /// 窗户抽象类，子类的窗户必须继承该类
    /// </summary>
    public abstract class Window
    {
        /// <summary>
        /// 创建窗户
        /// </summary>
        public abstract void Create();
    }
}