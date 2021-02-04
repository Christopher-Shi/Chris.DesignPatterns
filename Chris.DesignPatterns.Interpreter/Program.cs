using System;
using System.Collections;
using Chris.DesignPatterns.Interpreter.Expression;

namespace Chris.DesignPatterns.Interpreter
{
    /// <summary>
    /// 解释器模式（Interpreter Pattern）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var roman = "五亿七千三百零二万六千四百五十二";
            //分解：((五)亿)((七千)(三百)(零)(二)万)
            //((六千)(四百)(五十)(二))

            var context = new Context(roman);
            var tree = new ArrayList
            {
                new GeExpression(),
                new ShiExpression(),
                new BaiExpression(),
                new QianExpression(),
                new WanExpression(),
                new YiExpression()
            };


            foreach (Expression.Expression exp in tree)
            {
                exp.Interpreter(context);
            }

            Console.Write(context.Data);

            Console.ReadLine();
        }
    }
}
