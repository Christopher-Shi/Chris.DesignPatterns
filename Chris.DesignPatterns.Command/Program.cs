using System;
using Chris.DesignPatterns.Command.Command;

namespace Chris.DesignPatterns.Command
{
    /// <summary>
    /// 命令模式（Command Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //奶奶想吃猪肉大葱馅的饺子
            var liuAndLai = new PatrickLiuAndWife();//命令接受者
            Command.Command command = new MakeDumplingsCommand(liuAndLai);//命令
            var papa = new PaPaInvoker(command); //命令请求者

            //奶奶发布命令
            papa.ExecuteCommand();

            Console.ReadLine();
        }
    }
}
