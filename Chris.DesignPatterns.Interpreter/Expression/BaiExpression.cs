namespace Chris.DesignPatterns.Interpreter.Expression
{
    /// <summary>
    /// 百位表达式
    /// </summary>
    public sealed class BaiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}