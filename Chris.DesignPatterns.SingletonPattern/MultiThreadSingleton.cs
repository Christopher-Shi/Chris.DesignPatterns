namespace Chris.DesignPatterns.Singleton
{
    /// <summary>
    /// 多线程Singleton模式的实现
    /// </summary>
    public sealed class MultiThreadSingleton
    {
        // 定义一个静态变量来保存类的实例
        // 编译器在编译代码的时候会对代码的顺序进行微调，用volatile修饰保证了严格意义的顺序。
        // 一个定义为volatile的变量是说这变量可能会被意想不到地改变，这样，编译器就不会去假设这个变量的值了。
        // 精确地说就是，优化器在用到这个变量时必须每次都小心地重新读取这个变量的值，而不是使用保存在寄存器里的备份。
        private static volatile MultiThreadSingleton uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        // 定义私有构造函数，使外界不能创建该类实例
        private MultiThreadSingleton()
        {

        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static MultiThreadSingleton GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new MultiThreadSingleton();
                    }
                }
            }
            
            return uniqueInstance;
        }
    }
}