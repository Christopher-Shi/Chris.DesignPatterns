using System;

namespace Chris.DesignPatterns.Template
{
    /// <summary>
    /// 该类型就是抽象类角色--AbstractClass，定义做饺子的算法骨架，这里有三步骤，当然也可以有多个步骤，根据实际需要而定
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// 该方法就是模板方法，方法里面包含了做饺子的算法步骤，模板方法可以返回结果，也可以是void类型，视具体情况而定
        /// </summary>
        public void EatDumplings()
        {
            //和面
            MakingDough();
            //包馅
            MakeDumplings();
            //煮饺子
            BoiledDumplings();

            Console.WriteLine("饺子真好吃！");
        }

        /// <summary>
        /// 要想吃饺子第一步肯定是“和面”---该方法相当于算法中的某一步
        /// </summary>
        public abstract void MakingDough();

        /// <summary>
        /// 要想吃饺子第二部是“包饺子”---该方法相当于算法中的某一步
        /// </summary>
        public abstract void MakeDumplings();

        /// <summary>
        /// 要想吃饺子第三部是“煮饺子”---该方法相当于算法中的某一步
        /// </summary>
        public abstract void BoiledDumplings();
    }
}