namespace Chris.DesignPatterns.Singleton
{

    /// <summary>
    /// 支持多线程环境，因为只可能有一个线程执行静态构造器，不可能有多个线程去执行静态构造器，感觉就是程序已经自动为我们加锁了
    /// </summary>
    public sealed class SingletonOne
    {
        public static readonly SingletonOne instance = new SingletonOne();

        private SingletonOne() { }
    }

    /// <summary>
    /// 支持多线程环境，因为只可能有一个线程执行静态构造器，不可能有多个线程去执行静态构造器，感觉就是程序已经自动为我们加锁了
    /// </summary>
    public sealed class SingletonTwo
    {
        public static readonly SingletonTwo instance;


        //静态构造函数，CLR只执行一次
        static SingletonTwo()
        {
            instance = new SingletonTwo();
        }


        //私有构造函数，防止外界调用
        private SingletonTwo() { }
    }
}
