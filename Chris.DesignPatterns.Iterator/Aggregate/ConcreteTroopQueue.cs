using Chris.DesignPatterns.Iterator.Iterator;

namespace Chris.DesignPatterns.Iterator.Aggregate
{
    /// <summary>
    /// 部队队列具体聚合类--相当于具体聚合类ConcreteAggregate
    /// </summary>
    public sealed class ConcreteTroopQueue : ITroopQueue
    {
        private string[] collection;

        public ConcreteTroopQueue()
        {
            collection = new[] { "黄飞鸿", "方世玉", "洪熙官", "严咏春" };
        }

        public Iterator.Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length => collection.Length;

        public string GetElement(int index)
        {
            return collection[index];
        }
    }
}