using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 如何判断值类型和引用类型
            //引用类型
            //string
            //数组
            //class
            //interface
            //委托
            #endregion

            #region 语句块
            #endregion
            #region 变量的生命周期
            //编程时的大部分变量都是临时变量
            //例如函数、分支、循环中的语句
            //语句块执行结束后，没有被记录的对象就会被回收或者编程垃圾
            //值类型会被系统自动回收
            //引用类型：栈上用于存地址的空间被系统自动回收，堆中的内容编程垃圾，由GC回收

            //想要不被回收或者不变垃圾就得记录下来
            //在高层记录，例如使用全局静态变量记录
            #endregion
            #region 结构体中的值和引用
            //结构体本身是值类型
            //结构体中的引用类型还是引用类型
            
            #endregion 类中的值和引用
            //类本身是引用类型
            //！！！类中的值类型存在类所在的堆中！！（结构体中的值类型还是存在栈中）
            //类中的引用类型当然存在堆中，但是在类的堆地址中只存引用的地址，引用的值存在另一个地方

            #region 数组存储规则
            //数组本身是引用类型
            //数组元素是值类型的话，堆中存值
            //数组元素是引用类型的话，堆中存地址

            #endregion

            #region 结构体继承接口
            //用接口容器装载结构体存在装箱拆箱
            //结构体可以继承结构，继承之后编程引用类型

            #endregion


        }
    }
}
