namespace Chris.DesignPatterns.Composite.Safe
{
    /// <summary>
    /// 该抽象类就是文件夹抽象接口的定义，该类型就相当于是抽象构件Component类型
    /// </summary>
    public abstract class Folder //该类型少了容器对象管理子对象的方法的定义，换了地方，在树枝构件也就是SonFolder类型
    {
        /// <summary>
        /// 打开文件或者文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Open();
    }
}