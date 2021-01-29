using Chris.DesignPatterns.AbstractFactory.AbstractEntity;
using Chris.DesignPatterns.AbstractFactory.Entity;

namespace Chris.DesignPatterns.AbstractFactory.Factory
{
    /// <summary>
    /// 欧式风格房子的工厂，负责创建欧式风格的房子
    /// </summary>
    public class EuropeanFactory : AbstractFactory
    {
        // 制作欧式房顶
        public override Roof CreateRoof()
        {
            return new EuropeanRoof();
        }

        // 制作欧式地板
        public override Floor CreateFloor()
        {
            return new EuropeanFloor();
        }

        // 制作欧式窗户
        public override Window CreateWindow()
        {
            return new EuropeanWindow();
        }

        // 制作欧式房门
        public override Door CreateDoor()
        {
            return new EuropeanDoor();
        }
    }
}