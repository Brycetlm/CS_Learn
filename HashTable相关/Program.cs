using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //又称散列表，是基于键的哈希代码组织起来的键值对
            //主要作用是提高查询效率
            //使用键来访问集合中的元素

            //声明
            Hashtable ht = new Hashtable();


            //增删改查
            //1.增加
            //注意不能增加相同键
            ht.Add(1, "fghj");    //参数1为key，2为value，key和value都是object类型的
            ht.Add(1.3, "lop");
            ht.Add(true, 88666);
            //2.删
            //只能通过键去删除
            //删除不存在的键会没反应
            //也可以用Clear()删除
            ht.Remove(1);
            //3.查
            //通过键查看值,找不到返回空值
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[1.3]);
            //查看是否存在
            Console.WriteLine(ht.Contains(1));
            Console.WriteLine(ht.ContainsKey(1));
            Console.WriteLine(ht.ContainsValue("lop"));
            //4.改
            //只能改值，可以直接通过key找到value后改
            ht[1.3] = "gaigaigai";



            //遍历
            //1.遍历所有键
            Console.WriteLine("遍历所有键");
            foreach (var item in ht.Keys)  //《注意》，Keys
            {
                Console.WriteLine(item);
            }

            //2.遍历所有值
            Console.WriteLine("遍历所有值");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //3.键值对一起遍历!!!!!
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("键"+item.Key+"值"+item.Value);
            }

            //4.迭代器遍历


            //拆装箱

            Console.ReadLine();
        }
    }
}
