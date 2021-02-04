using System;

namespace Chris.DesignPatterns.Template
{
    /// <summary>
    /// 该类型是具体类角色--ConcreteClass，我想吃绿色面皮，猪肉大葱馅的饺子
    /// </summary>
    public sealed class ConcreteClass : AbstractClass
    {
        /// <summary>
        /// 要想吃饺子第一步肯定是“和面”---该方法相当于算法中的某一步
        /// </summary>
        public override void MakingDough()
        {
            //我想要面是绿色的，绿色健康嘛，就可以在此步定制了
            Console.WriteLine("在和面的时候加入芹菜汁，和好的面就是绿色的");
        }

        /// <summary>
        /// 要想吃饺子第二部是“包饺子”---该方法相当于算法中的某一步
        /// </summary>
        public override void MakeDumplings()
        {
            //我想吃猪肉大葱馅的，在此步就可以定制了
            Console.WriteLine("农家猪肉和农家大葱，制作成馅");
        }

        /// <summary>
        /// 要想吃饺子第三部是“煮饺子”---该方法相当于算法中的某一步
        /// </summary>
        public override void BoiledDumplings()
        {
            //我想吃大铁锅煮的饺子，有家的味道，在此步就可以定制了
            Console.WriteLine("用我家的大铁锅和大木材煮饺子");
        }
    }
}