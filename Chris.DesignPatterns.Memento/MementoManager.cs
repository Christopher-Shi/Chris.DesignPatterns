namespace Chris.DesignPatterns.Memento
{
    /// <summary>
    /// 管理角色，它可以管理【备忘录】对象，如果是保存多个【备忘录】对象，当然可以对保存的对象进行增、删等管理处理---相当于【管理者角色】Caretaker
    /// </summary>
    public sealed class MementoManager
    {
        //如果想保存多个【备忘录】对象，可以通过字典或者堆栈来保存，堆栈对象可以反映保存对象的先后顺序
        //比如：public Dictionary<string, ContactPersonMemento> ContactPersonMementoDictionary { get; set; }
        public ContactPersonMemento ContactPersonMemento { get; set; }
    }
}