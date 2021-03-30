using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体和类的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //结构体和类的最大区别在存储空间，结构体是值类型（堆），类是引用类型（栈）
            //结构体具有封装的特性，但是不具备继承和多态的性质，所以不能用protected修饰符

            //结构体成员变量声明不能初始化，但类可以
            //结构体中没有无参构造
            //结构体必须在构造函数中初始化所有成员，类不用
            //结构体不能被static修饰
            //结构体内部不能声明和自己一样的结构体变量，类可以


            //但是结构体可以继承接口


            //对象是数据集合时，例如地图位置，优先考虑结构体
            //从值类型和引用类型的区别考虑去选择
            //改变赋值对象时，不想源对象跟着变化就选结构体


        }
    }
}
