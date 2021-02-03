namespace Chris.DesignPatterns.Flyweight.Soldier
{
    /// <summary>
    /// 该类型就是抽象战士Soldier--该类型相当于抽象享元角色
    /// </summary>
    public abstract class Soldier
    {
        /// <summary>
        /// 通过构造函数初始化士兵的名称
        /// </summary>
        /// <param name="name"></param>
        protected Soldier(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 士兵的名字
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 可以传入不同的武器就用不同的活力---该方法相当于抽象Flyweight的Operation方法
        /// </summary>
        public abstract void Fight();

        public Weapen.Weapen WeapenInstance { get; set; }
    }
}