using System;

namespace Chris.DesignPatterns.Composite.Safe
{
    /// <summary>
    /// SonFolder类型就是树枝构件，现在由于我们使用的是“安全式”，所以Add,Remove都是从此处开始定义的
    /// </summary>
    public abstract class SonFolder : Folder //这里可以是抽象接口，可以自己根据自己的情况而定
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
        /// 打开文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }
}