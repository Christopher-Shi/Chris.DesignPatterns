using Chris.DesignPatterns.AbstractFactory.AbstractEntity;
using Chris.DesignPatterns.AbstractFactory.Entity;

namespace Chris.DesignPatterns.AbstractFactory.Factory
{
    /// <summary>
    /// 现在风格房子的工厂，负责创建现代风格的房子
    /// </summary>
    public class ModernizationFactory : AbstractFactory
    {
        // 制作现代房顶
        public override Roof CreateRoof()
        {
            return new ModernizationRoof();
        }

        // 制作现代地板
        public override Floor CreateFloor()
        {
            return new ModernizationFloor();
        }

        // 制作现代窗户
        public override Window CreateWindow()
        {
            return new ModernizationWindow();
        }

        // 制作现代房门
        public override Door CreateDoor()
        {
            return new ModernizationDoor();
        }
    }
}