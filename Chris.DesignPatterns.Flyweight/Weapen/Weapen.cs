namespace Chris.DesignPatterns.Flyweight.Weapen
{
    /// <summary>
    /// 此类型和享元没太大关系，可以算是享元对象的状态吧，需要从外部定义
    /// </summary>
    public abstract class Weapen
    {
        public abstract void Fire(string jobName);
    }
}