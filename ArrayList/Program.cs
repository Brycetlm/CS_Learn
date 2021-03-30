using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList是一个Cs帮我们封装好的类，本质是object数组,所以可以存储任何东西在里面
            //ArrayList里有很多方法
            //在using System.Collections;中

            //声明
            ArrayList arr = new ArrayList();


            //增删改查
            //1.增
            arr.Add(100);
            arr.Add("6dddd546540");
            arr.Add(true);
            arr.Add(new object());
            //范围增加，一次增加很多
            //arr.AddRange(arr);  //这里就把arr加到了arr里面，也可以直接用Add(arr)；
            Console.WriteLine(arr); //这样打印只能打印arraylist的名字，打印内容需要索引
            Console.WriteLine("count"+arr.Count);
            //for (int i=0;i<arr.Count;i++)   //注意不是length是count
            //{

            //    Console.WriteLine(arr[i]);
            //}


            //2.删
            arr.Remove("6dddd546540");   //指定元素删除
            arr.RemoveAt(2);   //指定位置删除
            for (int i = 0; i < arr.Count; i++)   //注意不是length是count
            {

                Console.WriteLine(arr[i]);
            }
            //2.1清空，arr.Clear();


            //3.查指定位置元素
            Console.WriteLine(arr[0]);
            //3.1查看元素是否存在
            Console.WriteLine(arr.Contains(100));
            //3.2正向查找元素位置,第一个元素位置,注意无论正反向查找，返回的都是下标值，从左往右数的
            int index = arr.IndexOf(100);
            Console.WriteLine("index:" + index);
            //3.3反向查找元素位置,第一个元素位置
            arr.Add(100);
            index = arr.LastIndexOf(100);
            Console.WriteLine("index:" + index);

            //4.改
            //ArrayList可以直接下标索引修改
            arr[0] = "101";

            //遍历
            //1.直接for循环遍历，注意长度不是length而是count，因为这里的一个元素并不只占一个空间，用length不准确
            //2.迭代器遍历
            Console.WriteLine("foreach遍历");
            foreach (object item in arr)   //取出arr中的所有元素依次放到item里面
            {
                Console.WriteLine(item);
            }







            //拆箱装箱
            //拆箱：堆内存->栈内存;装箱:栈内存->堆内存
            //因为ArrayList实际上是object数组（object是引用），所以当把值类型放进去的时候就是装箱，取出值类型则是拆箱
            //所以ArrayList存值类型是有性能多消耗的




            Console.ReadLine();

        }
    }
}
