using System.Collections;

namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 亿位表达式
    /// </summary>
    public sealed class YiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "亿";
        }

        public override int Multiplier()
        {
            return 100000000;
        }

        public override void Interpreter(Context context)
        {
            var tree = new ArrayList
            {
                new GeExpression(), new ShiExpression(), new BaiExpression(), new QianExpression()
            };


            foreach (var key in table.Keys)
            {
                if (context.Statement.EndsWith(GetPostFix()))
                {
                    var temp = context.Data;
                    context.Data = 0;
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());

                    foreach (Expression exp in tree)
                    {
                        exp.Interpreter(context);
                    }
                    context.Data = temp + context.Data * this.Multiplier();
                }
            }
        }
    }
}