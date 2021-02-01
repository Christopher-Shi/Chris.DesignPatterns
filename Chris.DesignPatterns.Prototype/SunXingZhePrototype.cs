using System;

namespace Chris.DesignPatterns.Prototype
{
    /// <summary>
    /// 具体原型，例如：孙行者，他只负责与自然界修炼成妖的战斗和化斋水果
    /// </summary>
    public sealed class SunXingZhePrototype : Prototype
    {
        /// <summary>
        /// 战斗--保护师傅-与天界宠物战斗
        /// </summary>
        public override void Fight()
        {
            Console.WriteLine("腾云驾雾，各种武艺");
        }

        /// <summary>
        /// 化缘--不要饿着师傅---水果类
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
            return (SunXingZhePrototype)MemberwiseClone();
        }
    }
}