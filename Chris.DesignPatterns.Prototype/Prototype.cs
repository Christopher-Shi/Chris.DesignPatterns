namespace Chris.DesignPatterns.Prototype
{
    /// <summary>
    /// 抽象原型，定义了原型本身所具有特征和动作，该类型就是至尊宝
    /// </summary>
    public abstract class Prototype
    {
        /// <summary>
        /// 战斗--保护师傅
        /// </summary>
        public abstract void Fight();

        /// <summary>
        /// 化缘--不要饿着师傅
        /// </summary>
        public abstract void BegAlms();

        /// <summary>
        /// 吹口仙气--变化一个自己出来
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
}