namespace Chris.DesignPatterns.Command.Command
{
    /// <summary>
    /// 该类型就是抽象命令角色--Commmand，定义了命令的抽象接口，任务是包饺子
    /// </summary>
    public abstract class Command
    {
        //真正任务的接受者
        protected PatrickLiuAndWife _worker;

        protected Command(PatrickLiuAndWife worker)
        {
            _worker = worker;
        }

        /// <summary>
        /// 该方法就是抽象命令对象Command的Execute方法
        /// </summary>
        public abstract void MakeDumplings();
    }
}