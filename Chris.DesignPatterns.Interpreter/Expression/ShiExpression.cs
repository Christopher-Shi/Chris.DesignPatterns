namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 十位表达式
    /// </summary>
    public sealed class ShiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}