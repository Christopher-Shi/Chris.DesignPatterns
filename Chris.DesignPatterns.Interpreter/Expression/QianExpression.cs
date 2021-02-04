namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 千位表达式
    /// </summary>
    public sealed class QianExpression : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}