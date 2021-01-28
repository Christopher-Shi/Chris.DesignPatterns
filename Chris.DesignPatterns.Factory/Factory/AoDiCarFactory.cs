using Chris.DesignPatterns.Factory.Car;

namespace Chris.DesignPatterns.Factory.Factory
{
    /// <summary>
    /// 奥迪汽车工厂类
    /// </summary>
    public class AoDiCarFactory : Factory
    {
        /// <summary>
        /// 负责创建奥迪汽车
        /// </summary>
        /// <returns></returns>
        public override Car.Car CreateCar()
        {
            return new AoDiCar();
        }
    }
}