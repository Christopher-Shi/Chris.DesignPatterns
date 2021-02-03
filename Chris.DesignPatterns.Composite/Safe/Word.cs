using System;

namespace Chris.DesignPatterns.Composite.Safe
{
    /// <summary>
    /// 该Word文档类就是叶子构件的定义，该类型就相当于是Leaf类型，不能在包含子对象
    /// </summary>
    public sealed class Word : Folder //这类型现在很干净
    {
        /// <summary>
        /// 打开文件--该操作相当于Component类型的Operation方法
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("打开Word文档，开始进行编辑");
        }
    }
}