using System;
using Chris.DesignPatterns.Iterator.Aggregate;

namespace Chris.DesignPatterns.Iterator
{
    /// <summary>
    /// 迭代器模式（Iterator Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Iterator.Iterator iterator;
            ITroopQueue list = new ConcreteTroopQueue();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                var ren = (string)iterator.GetCurrent();
                Console.WriteLine(ren);
                iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
