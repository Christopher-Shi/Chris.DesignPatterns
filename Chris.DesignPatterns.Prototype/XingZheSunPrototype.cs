using System;

namespace Chris.DesignPatterns.Prototype
{
    /// <summary>
    /// 具体原型，例如：行者孙，他只负责化斋饭食和与天界宠物下界的妖怪的战斗
    /// </summary>
    public sealed class XingZheSunPrototype : Prototype
    {
        /// <summary>
        /// 战斗--保护师傅--与自然修炼成妖的战斗
        /// </summary>
        public override void Fight()
        {
            Console.WriteLine("腾云驾雾，各种武艺");
        }

        /// <summary>
        /// 化缘--不要饿着师傅--饭食类
        /// </summary>
        public override void BegAlms()
        {
            Console.WriteLine("什么都能要来");
        }

        /// <summary>
        /// 吹口仙气--变化一个自己出来
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            return (XingZheSunPrototype)MemberwiseClone();
        }
    }
}
