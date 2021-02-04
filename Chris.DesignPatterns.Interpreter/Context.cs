namespace Chris.DesignPatterns.Interpreter
{
    /// <summary>
    /// 环境上下文
    /// </summary>
    public sealed class Context
    {
        private string _statement;
        private int _data;

        public Context(string statement)
        {
            _statement = statement;
        }

        public string Statement
        {
            get { return _statement; }
            set { _statement = value; }
        }

        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}