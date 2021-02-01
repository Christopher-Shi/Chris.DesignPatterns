using System;

namespace Chris.DesignPatterns.Prototype
{
    /// <summary>
    /// 原型模式（Prototype Pattern）【创建型】
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var xingZheSun = new XingZheSunPrototype();
            var xingZheSun2 = xingZheSun.Clone();
            var xingZheSun3 = xingZheSun.Clone();

            var sunXingZhe = new SunXingZhePrototype();
            var sunXingZhe2 = sunXingZhe.Clone();
            var sunXingZhe3 = sunXingZhe.Clone();
            var sunXingZhe4 = sunXingZhe.Clone();
            var sunXingZhe5 = sunXingZhe.Clone();

            //1号孙行者打妖怪
            sunXingZhe.Fight();
            //2号孙行者去化缘
            sunXingZhe2.BegAlms();

            //战斗和化缘也可以分类，比如化缘，可以分：水果类化缘，饭食类化缘；
            //战斗可以分为：天界宠物下界成妖的战斗，自然修炼成妖的战斗，大家可以自己去想吧，原型模式还是很有用的

            Console.ReadLine();
        }
    }
}
