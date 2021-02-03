using System;

namespace Chris.DesignPatterns.Bridge
{
    /// <summary>
    /// 桥接模式（Bridge Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PlatformImplementor SqlServer2000UnixImp = new SqlServer2000UnixImplementor();
            //还可以针对不同平台进行扩展，也就是子类化，这个是独立变化的

            Database SqlServer2000Unix = new SqlServer2000(SqlServer2000UnixImp);
            //数据库版本也可以进行扩展和升级，也进行独立的变化。

            //以上就是两个维度的变化。

            //就可以针对Unix执行操作了
            SqlServer2000Unix.Create();

            Console.ReadLine();
        }
    }
}
