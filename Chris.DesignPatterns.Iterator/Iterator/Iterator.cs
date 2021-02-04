namespace Chris.DesignPatterns.Iterator.Iterator
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();

        object GetCurrent();

        void Next();

        void Reset();
    }
}