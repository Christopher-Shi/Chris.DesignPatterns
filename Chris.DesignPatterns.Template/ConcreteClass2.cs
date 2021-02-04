using System;

namespace Chris.DesignPatterns.Template
{
    /// <summary>
    /// 该类型是具体类角色--ConcreteClass2，我想吃橙色面皮，韭菜鸡蛋馅的饺子
    /// </summary>
    public sealed class ConcreteClass2 : AbstractClass
    {
        /// <summary>
        /// 要想吃饺子第一步肯定是“和面”---该方法相当于算法中的某一步
        /// </summary>
        public override void MakingDough()
        {
            //我想要面是橙色的，加入胡萝卜汁就可以。在此步定制就可以了。
            Console.WriteLine("在和面的时候加入胡萝卜汁，和好的面就是橙色的");
        }

        /// <summary>
        /// 要想吃饺子第二部是“包饺子”---该方法相当于算法中的某一步
        /// </summary>
        public override void MakeDumplings()
        {
            //我想吃韭菜鸡蛋馅的，在此步就可以定制了
            Console.WriteLine("农家鸡蛋和农家韭菜，制作成馅");
        }

        /// <summary>
        /// 要想吃饺子第三部是“煮饺子”---该方法相当于算法中的某一步
        /// </summary>
        public override void BoiledDumplings()
        {
            //此处没要求
            Console.WriteLine("可以用一般煤气和不粘锅煮就可以");
        }
    }
}