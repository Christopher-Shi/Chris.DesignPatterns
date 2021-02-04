using System.Collections.Generic;

namespace Chris.DesignPatterns.Memento
{
    /// <summary>
    /// 备忘录对象，用于保存状态数据，保存的是当时对象具体状态数据--相当于【备忘录角色】Memeto
    /// </summary>
    public sealed class ContactPersonMemento
    {
        /// <summary>
        /// 保存发起人创建的电话名单数据，就是所谓的状态
        /// </summary>
        public List<ContactPerson> ContactPersonListBack { get; private set; }

        public ContactPersonMemento(List<ContactPerson> personList)
        {
            ContactPersonListBack = personList;
        }
    }
}