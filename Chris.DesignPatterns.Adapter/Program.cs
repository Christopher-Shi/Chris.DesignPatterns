using System;
using Chris.DesignPatterns.Adapter.ClassAdapter;
using Chris.DesignPatterns.Adapter.ObjectAdapter;
using ThreeToTwoAdapter = Chris.DesignPatterns.Adapter.ObjectAdapter.ThreeToTwoAdapter;

namespace Chris.DesignPatterns.Adapter
{
    /// <summary>
    /// 适配器模式（Adapter Pattern）【结构型】
    /// 家里只有两个孔的插座，也懒得买插线板了，还要花钱，但是我的手机是一个有3个小柱子的插头，明显直接搞不定，那就适配吧
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 对象适配器
            //好了，现在就可以给手机充电了
            TwoHoleTarget homeTwoHole = new ObjectAdapter.ThreeToTwoAdapter();
            homeTwoHole.Request();
            #endregion

            #region 类适配器
            //好了，现在可以充电了
            ITwoHoleTarget change = new ClassAdapter.ThreeToTwoAdapter();
            change.Request();
            #endregion

            Console.ReadLine();
        }
    }
}
