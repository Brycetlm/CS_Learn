using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 迭代器
{
    #region 迭代器是什么
    //也称光标
    //是程序设计的软件设计模式
    //迭代器模式提供一个方法顺序访问一个聚合对象中的各个元素
    //而又不暴露其内部的标识

    //在效果上
    //是可以在容器对象，例如链表或者数组上遍历访问的接口
    //设计人员无需关系容器对象的内存分配细节
    //可以用foreach遍历的类都是实现了迭代器的
    #endregion

    #region 标准迭代器实现方法
    //核心是两个接口： IEnumerator,Ienumerable
    //通过同时继承这两个及接口实现其中的方法
    class CustoList:IEnumerator,IEnumerable
    {
        private int[] list;

        //光标。从-1开始
        private int position = -1;
        public CustoList()
        {
            list = new int[] { 1, 2, 3, 4, 5 };
        }

        public object Current
        {
            get
            {
                return list[position];
     
            }
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public bool MoveNext()
        {
            ++position;
            return position < list.Length;
        }

        public void Reset()
        {
            this.position = -1;
        }
    }

    #endregion

    #region yield return 语法糖实现迭代器
    //将复杂逻辑简单化，增加程序可读性
    //这样可以只需要继承IEnumerable
    class Test2 :IEnumerable
    {
        private int[] list;
        public Test2()
        {
            this.list = new int[] { 1, 2, 2, 6, 9 };
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                //yield配合迭代器使用
                //可以理解为暂时返回
                yield return list[i];   
            }
        }
    }
    #endregion

    #region yield return 语法糖为泛型类实现迭代器
    class Test3<T> : IEnumerable
    {
        private T[] list;
        public Test3(T[] a)
        {
            this.list = a;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                //yield配合迭代器使用
                //可以理解为暂时返回
                yield return list[i];
            }
        }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            CustoList list = new CustoList();
            //foreach本质
            //1.先获取in后面这个对象的IEnumerator
            //会调用对象其中的方法 GetEnumerator方法
            //2.执行这个对象中的MoveNext方法
            //如果返回为true，则运行Current得到值，然后赋值给item
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
