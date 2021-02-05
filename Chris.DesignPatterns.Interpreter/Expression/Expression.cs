using System.Collections.Generic;

namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class Expression
    {
        protected Dictionary<string, int> table = new(9);

        protected Expression()
        {
            table.Add("一", 1);
            table.Add("二", 2);
            table.Add("三", 3);
            table.Add("四", 4);
            table.Add("五", 5);
            table.Add("六", 6);
            table.Add("七", 7);
            table.Add("八", 8);
            table.Add("九", 9);
        }

        public virtual void Interpreter(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            foreach (var key in table.Keys)
            {
                var value = table[key];

                if (context.Statement.EndsWith(key + GetPostFix()))
                {
                    context.Data += value * Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - GetLength());
                }
                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostFix();

        public abstract int Multiplier();

        /// <summary>
        /// 这个可以通用，但是对于个位数字例外，所以用虚方法
        /// </summary>
        /// <returns></returns>
        public virtual int GetLength()
        {
            return GetPostFix().Length + 1;
        }
    }
}