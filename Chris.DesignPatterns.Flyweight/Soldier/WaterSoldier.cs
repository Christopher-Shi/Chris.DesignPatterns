namespace Chris.DesignPatterns.Flyweight.Soldier
{
    /// <summary>
    /// 这是海军陆战队队员，武器精良----相当于具体的Flyweight角色
    /// </summary>
    public sealed class WaterSoldier : Soldier
    {
        /// <summary>
        /// 通过构造函数初始化士兵的名称
        /// </summary>
        /// <param name="name"></param>
        public WaterSoldier(string name) : base(name)
        {

        }

        /// <summary>
        /// 执行享元的方法---就是Flyweight类型的Operation方法
        /// </summary>
        public override void Fight()
        {
            WeapenInstance.Fire("士兵：" + Name + " 在海中执行击毙任务");
        }
    }
}