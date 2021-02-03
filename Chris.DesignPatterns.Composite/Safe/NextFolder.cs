using System;

namespace Chris.DesignPatterns.Composite.Safe
{
    /// <summary>
    /// NextFolder类型就是树枝构件的实现类
    /// </summary>
    public sealed class NextFolder : SonFolder
    {
        /// <summary>
        /// 增加文件夹或文件
        /// </summary>
        /// <param name="folder"></param>
        public override void Add(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经增加成功");
        }

        /// <summary>
        /// 删除文件夹或者文件
        /// </summary>
        /// <param name="folder"></param>
        public override void Remove(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经删除成功");
        }

        /// <summary>
        /// 打开文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }
}