namespace Chris.DesignPatterns.Factory.Factory
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <returns></returns>
        public abstract Car.Car CreateCar();
    }
}
