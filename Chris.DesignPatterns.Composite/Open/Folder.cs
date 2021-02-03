using Chris.DesignPatterns.Composite.Open;

namespace Chris.DesignPatterns.Composite.Open
{
    /// <summary>
    /// 该抽象类就是文件夹抽象接口的定义，该类型就相当于是抽象构件Component类型
    /// </summary>
    public abstract class Folder
    {
        /// <summary>
        /// 增加文件夹或文件
        /// </summary>
        /// <param name="folder"></param>
        public abstract void Add(Folder folder);

        /// <summary>
        /// 删除文件夹或者文件
        /// </summary>
        /// <param name="folder"></param>
        public abstract void Remove(Folder folder);

        /// <summary>
        /// 打开文件或者文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Open();
    }
}