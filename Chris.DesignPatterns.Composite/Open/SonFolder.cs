using System;

namespace Chris.DesignPatterns.Composite.Open
{
    /// <summary>
    /// SonFolder类型就是树枝构件，由于我们使用的是“透明式”，所以Add,Remove都是从Folder类型继承下来的
    /// </summary>
    public class SonFolder : Folder
    {
        //增加文件夹或文件
        public override void Add(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经增加成功");
        }

        //删除文件夹或者文件
        public override void Remove(Folder folder)
        {
            Console.WriteLine("文件或者文件夹已经删除成功");
        }

        //打开文件夹--该操作相当于Component类型的Operation方法
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }
}