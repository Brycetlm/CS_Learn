using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList相关
{
    class Program
    {
        static void Main(string[] args)
        {

            //本质
            //是一个可变类型的《泛型》《双向》链表

            //声明
            //using System.Collections.Generic;
            LinkedList<int> list = new LinkedList<int>();


            //增删改查
            //1.增
            list.AddLast(10);
            list.AddFirst(20);
            //list.AddAfter

            //2.删
            //list.RemoveFirst();
            //list.RemoveLast();
            //list.Remove(10);

            //3.查
            //查头尾结点
            LinkedListNode<int> first = list.First;
            LinkedListNode<int> last = list.Last;
            //找到指定值的结点
            LinkedListNode<int> Specific = list.Find(10);
            //判断是否存在
            list.Contains(10);

            //4.改
            //先找到结点
            //再改值
            first.Value = 565;


            //遍历
            //1.foreach遍历 
            foreach (int item in list)   //这里取出来的不是node，而是value
            {
                Console.WriteLine(item);
            }
            //2.从头到尾
            //得到头节点
            Console.WriteLine("-****************************************");
            LinkedListNode<int> headnode = list.First;
            while(headnode!=null)
            {
                Console.WriteLine(headnode.Value);
                headnode = headnode.Next;
            }
            //3.从尾到头
            Console.WriteLine("-****************************************");
            LinkedListNode<int> lastnode = list.Last;
            while (lastnode != null)
            {
                Console.WriteLine(lastnode.Value);
                lastnode = lastnode.Previous;
            }

            Console.ReadLine();
        }
    }
}
