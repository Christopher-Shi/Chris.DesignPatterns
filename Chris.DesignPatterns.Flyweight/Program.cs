using System;
using Chris.DesignPatterns.Flyweight.Weapen;

namespace Chris.DesignPatterns.Flyweight
{
    /// <summary>
    /// 享元模式（Flyweight Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //比如，我们现在需要10000个一般士兵，只需这样
            var factory = new SoldierFactory();
            var ak47 = new AK47();
            for (var i = 0; i < 100; i++)
            {
                Soldier.Soldier soldier = null;
                if (i <= 20)
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Normal);
                }
                else
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Water);
                }
                soldier.Fight();
            }
            //我们有这么多的士兵，但是使用的内存不是很多，因为我们缓存了。

            Console.ReadLine();
        }
    }
}
