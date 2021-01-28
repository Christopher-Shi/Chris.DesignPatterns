using Chris.DesignPatterns.Factory.Car;

namespace Chris.DesignPatterns.Factory.Factory
{
    /// <summary>
    /// 红旗汽车工厂类
    /// </summary>
    public class HongQiCarFactory : Factory
    {
        /// <summary>
        /// 负责生产红旗汽车
        /// </summary>
        /// <returns></returns>
        public override Car.Car CreateCar()
        {
            return new HongQiCar();
        }
    }
}