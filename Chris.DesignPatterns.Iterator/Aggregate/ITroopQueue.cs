namespace Chris.DesignPatterns.Iterator.Aggregate
{
    /// <summary>
    /// 部队队列的抽象聚合类--该类型相当于抽象聚合类Aggregate
    /// </summary>
    public interface ITroopQueue
    {
        Iterator.Iterator GetIterator();
    }
}