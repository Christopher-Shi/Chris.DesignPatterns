using Chris.DesignPatterns.Decorator.Component;

namespace Chris.DesignPatterns.Decorator.Decorator
{
    /// <summary>
    /// 该抽象类就是装饰接口的定义，该类型就相当于是Decorator类型，如果需要具体的功能，可以子类化该类型
    /// </summary>
    public abstract class DecorationStrategy : House //关键点之二，体现关系为Is-a，有这这个关系，装饰的类也可以继续装饰了
    {
        //通过组合方式引用Decorator类型，该类型实施具体功能的增加
        //这是关键点之一，包含关系，体现为Has-a
        protected House _house;

        //通过构造器注入，初始化平台实现
        protected DecorationStrategy(House house)
        {
            _house = house;
        }

        //该方法就相当于Decorator类型的Operation方法
        public override void Renovation()
        {
            _house?.Renovation();
        }
    }
}