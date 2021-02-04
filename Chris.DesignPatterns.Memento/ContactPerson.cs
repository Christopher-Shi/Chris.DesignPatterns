namespace Chris.DesignPatterns.Memento
{
    /// <summary>
    /// 联系人--需要备份的数据，是状态数据，没有操作
    /// </summary>
    public sealed class ContactPerson
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string MobileNumber { get; set; }
    }
}