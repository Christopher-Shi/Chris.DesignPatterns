namespace Chris.DesignPatterns.Mediator
{
    /// <summary>
    /// 抽象中介者角色
    /// </summary>
    public interface Mediator
    {
        void Command(Department.Department department);
    }
}