using System;
using System.Collections.Generic;
using Chris.DesignPatterns.Flyweight.Soldier;

namespace Chris.DesignPatterns.Flyweight
{
    /// <summary>
    /// 该类型相当于是享元的工厂---相当于FlyweightFactory类型
    /// </summary>
    public class SoldierFactory
    {
        private static IList<Soldier.Soldier> soldiers;

        static SoldierFactory()
        {
            soldiers = new List<Soldier.Soldier>();
        }

        Soldier.Soldier mySoldier = null;

        /// <summary>
        /// 因为我这里有两种士兵，所以在这里可以增加另外一个参数，士兵类型，原模式里面没有，
        /// </summary>
        public Soldier.Soldier GetSoldier(string name, Weapen.Weapen weapen, SoldierType soldierType)
        {
            foreach (var soldier in soldiers)
            {
                if (string.Compare(soldier.Name, name, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    mySoldier = soldier;
                    return mySoldier;
                }
            }
            //我们这里就任务名称是唯一的
            if (soldierType == SoldierType.Normal)
            {
                mySoldier = new NormalSoldier(name);
            }
            else
            {
                mySoldier = new WaterSoldier(name);
            }
            mySoldier.WeapenInstance = weapen;

            soldiers.Add(mySoldier);
            return mySoldier;
        }
    }
}