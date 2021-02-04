namespace Chris.DesignPatterns.Command.Command
{
    /// <summary>
    /// 该类型是具体命令角色--ConcreteCommand，这个命令完成制作“猪肉大葱馅”的饺子
    /// </summary>
    public sealed class MakeDumplingsCommand : Command
    {
        public MakeDumplingsCommand(PatrickLiuAndWife worker) : base(worker)
        {

        }

        /// <summary>
        /// 执行命令--包饺子
        /// </summary>
        public override void MakeDumplings()
        {
            //执行命令---包饺子
            _worker.Execute("今天包的是农家猪肉和农家大葱馅的饺子");
        }
    }
}