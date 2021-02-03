using System;

namespace Chris.DesignPatterns.Composite.Open
{
    /// <summary>
    /// 该Word文档类就是叶子构件的定义，该类型就相当于是Leaf类型，不能在包含子对象
    /// </summary>
    public sealed class Word : Folder
    {
        //增加文件夹或文件
        public override void Add(Folder folder)
        {
            throw new Exception("Word文档不具有该功能");
        }

        //删除文件夹或者文件
        public override void Remove(Folder folder)
        {
            throw new Exception("Word文档不具有该功能");
        }

        //打开文件--该操作相当于Component类型的Operation方法
        public override void Open()
        {
            Console.WriteLine("打开Word文档，开始进行编辑");
        }
    }
}