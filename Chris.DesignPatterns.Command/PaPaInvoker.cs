namespace Chris.DesignPatterns.Command
{
    /// <summary>
    /// 这个类型就是请求者角色--也就是我爸爸的角色，告诉奶奶要吃饺子
    /// </summary>
    public sealed class PaPaInvoker
    {
        //我爸爸从奶奶那里接受到的命令
        private Command.Command _command;

        /// <summary>
        /// 爸爸开始接受具体的命令
        /// </summary>
        /// <param name="command"></param>
        public PaPaInvoker(Command.Command command)
        {
            _command = command;
        }

        /// <summary>
        /// 爸爸给我们下达命令
        /// </summary>
        public void ExecuteCommand()
        {
            _command.MakeDumplings();
        }
    }
}