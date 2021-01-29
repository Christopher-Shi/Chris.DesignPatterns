using Chris.DesignPatterns.AbstractFactory.AbstractEntity;

namespace Chris.DesignPatterns.AbstractFactory.Factory
{
    public abstract class AbstractFactory
    {
        // 抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了房顶、地板、窗户和房门创建接口
        public abstract Roof CreateRoof();
        public abstract Floor CreateFloor();
        public abstract Window CreateWindow();
        public abstract Door CreateDoor();
    }
}