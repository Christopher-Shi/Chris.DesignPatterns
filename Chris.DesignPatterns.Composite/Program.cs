using System;

namespace Chris.DesignPatterns.Composite
{
    /// <summary>
    /// 组合模式（Composite Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region 透明模式

            {
                Open.Folder myWord = new Open.Word();
                myWord.Open();//打开文件，处理文件
                myWord.Add(new Open.SonFolder());//抛出异常
                myWord.Remove(new Open.SonFolder());//抛出异常
            }

            {
                Open.Folder myFolder = new Open.SonFolder();
                myFolder.Open();//打开文件夹
                myFolder.Add(new Open.SonFolder());//成功增加文件或者文件夹
                myFolder.Remove(new Open.SonFolder());//成功删除文件或者文件夹
            }

            #endregion

            #region 安全模式

            {
                Safe.Folder myword = new Safe.Word();
                myword.Open();//打开文件，处理文件

                Safe.Folder myfolder = new Safe.NextFolder();
                myfolder.Open();//打开文件夹

                //此处要是用增加和删除功能，需要转型的操作，否则不能使用
                ((Safe.SonFolder)myfolder).Add(new Safe.NextFolder());//成功增加文件或者文件夹
                ((Safe.SonFolder)myfolder).Remove(new Safe.NextFolder());//成功删除文件或者文件夹
            }

            #endregion

            Console.ReadLine();
        }
    }
}
