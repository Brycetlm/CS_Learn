using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List排序
{
    class Item:IComparable<Item>
    {
        public int money;
        public Item(int money)
        {
            this.money = money;
        }

        public int CompareTo(Item other)
        {
            //排序逻辑
            ////
            // 摘要:
            //     将当前实例与同一类型的另一个对象进行比较，并返回一个整数，该整数指示当前实例在排序顺序中的位置是位于另一个对象之前、之后还是与其位置相同。
            //
            // 参数:
            //   other:
            //     与此实例进行比较的对象。
            //
            // 返回结果:
            //     一个值，指示要比较的对象的相对顺序。 返回值的含义如下： 值 含义 小于零 此实例在排序顺序中位于 other 之前。 零 此实例中出现的相同位置在排序顺序中是
            //     other。 大于零 此实例在排序顺序中位于 other 之后。
            if (this.money>other.money)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    class ShopItem
    {
        public int id;
        public ShopItem(int id)
        {
            this.id = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1.List自带排序
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(20);
            list.Add(5);
            list.AddRange(list);
            Console.WriteLine("未排序打印");
            foreach (var item in list)
            {
                Console.WriteLine(item);  //未排序打印

            }
            list.Sort();

            Console.WriteLine("排序打印");
            foreach (var item in list)
            {
                Console.WriteLine(item);  //排序打印

            }

            //ArrayList里也有Sort方法

            //2.对自定义类的排序,必须要在自定义对象里实现排序的接口 IComparable,然后实现CompareTo方法
            //也可以继承CompareTo接口，但是这个接口要求是object，不是泛型，比较麻烦
            List<Item> it = new List<Item>();
            Item it1 = new Item(1555);
            Item it2 = new Item(10);
            Item it3 = new Item(18);
            it.Add(it1);
            it.Add(it2);
            it.Add(it3);
            Console.WriteLine("对自定义类型的排序打印");
            it.Sort();
            foreach (var item in it)
            {
                Console.WriteLine(item.money);  //对自定义类型的排序打印

            }


            //3.通过委托函数进行排序
            //实际上就是将函数传进Sort方法里（因为Sort的一个重载里允许匿名函数为参数）

            ShopItem i1 = new ShopItem(1);
            ShopItem i2 = new ShopItem(81);
            ShopItem i3 = new ShopItem(5);
            List<ShopItem> shop = new List<ShopItem>();
            shop.Add(i1);
            shop.Add(i2);
            shop.Add(i3);
            shop.Sort(SortShopId);
            Console.WriteLine("对自定义类型的排序打印(匿名函数方法)");
            foreach (var item in shop)
            {
                Console.WriteLine(item.id);
            }

            //3.1也可以直接把匿名函数或者LAmda写在Sort里面
            //3.1.1 匿名函数
            //这样代码量比较小
            Console.WriteLine("对自定义类型的排序打印(匿名函数方法)");
            shop.Sort(delegate (ShopItem a, ShopItem b)
            {
                if (a.id > b.id)
                {
                    return 1;
                }
                else { return -1; }
            });
            foreach (var item in shop)
            {
                Console.WriteLine(item.id);
            }
            //3.1.2 Lamda函数
            Console.WriteLine("对自定义类型的排序打印(Lamda方法)");
            shop.Sort((ShopItem a, ShopItem b) => 
            {
               return a.id>b.id? 1:-1;  //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            });

            foreach (var item in shop)
            {
                Console.WriteLine(item.id);
            }

            //里面的if else语句可以简化为三目运算


            Console.ReadLine();
        }

        public static int SortShopId(ShopItem a,ShopItem b)
        {
            if(a.id>b.id)
            {
                return 1;
            }
            else { return -1; }
        }
    }
}
