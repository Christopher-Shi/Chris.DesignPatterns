namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 个位表达式
    /// </summary>
    public sealed class GeExpression : Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override int Multiplier()
        {
            return 1;
        }

        public override int GetLength()
        {
            return 1;
        }
    }
}