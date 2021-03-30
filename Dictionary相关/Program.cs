using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary的本质
            //可以将dictionary理解为拥有泛型的HashTable
            //它也是基于键的哈希代码组织起来的键值对
            //键值对类型从HashTable的object变成了可自定义的泛型

            //声明
            //using System.Collections.Generic;
            Dictionary<int, string> di = new Dictionary<int, string>();

            //增删改查

            //1.增
            di.Add(1, "kkl");
            di.Add(2, "ghjk");

            //2.删
            //remove

            //3.改
            di[1] = "fghjbknm";

            //4.查
            Console.WriteLine(di[1]);
            //找不到会报错
            //根据键、值查找
            Console.WriteLine(di.ContainsKey(1));//True
            Console.WriteLine(di.ContainsValue("gg")); //False


            //遍历
            //1.遍历所有键
            foreach (int item in di.Keys)
            {
                Console.WriteLine(item);
            }
            //2.遍历所有值
            foreach (string item in di.Values)
            {
                Console.WriteLine(item);
            }

            //3.键值对一起遍历《！！！！》
            foreach (KeyValuePair<int,string> item in di)
            {
                Console.WriteLine("键"+item.Key+"值"+item.Value);
            }



            Console.ReadLine();
        }
    }
}
