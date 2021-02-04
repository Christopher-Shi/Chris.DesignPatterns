using System;

namespace Chris.DesignPatterns.Mediator.Department
{
    /// <summary>
    /// 财务部门
    /// </summary>
    public sealed class Financial : Department
    {
        public Financial(Mediator mediator) : base(mediator)
        {

        }

        public override void Process()
        {
            Console.WriteLine("汇报工作！没钱了，钱太多了！怎么花?");
        }

        public override void Apply()
        {
            Console.WriteLine("数钱！");
        }
    }
}