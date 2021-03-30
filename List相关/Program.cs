using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List相关
{

    class Program
    {
        static void Main(string[] args)
        {
            //List本质
            //本质是一个可变类型的泛型数组
            //cs封装好的类

            //声明
            //需要命名空间using System.Collections.Generic;
            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            //也可以装自己声明的类型


            //增删改查
            //1.增
            list.Add(1);
            list.Add(3);
            list.AddRange(list);

            //2.删
            list.Remove(1);
            list.RemoveAt(0);
            //list.RemoveAll(1);

            //3.改
            //list[0]=1;
            //Inert


            //4.查
            //contains
            //IndexOf
            //LastIndexOf

            //遍历



        }
    }
}
