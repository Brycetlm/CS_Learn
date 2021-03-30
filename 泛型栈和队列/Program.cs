using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型栈和队列
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 回顾数据容器
            //1.变量
            //无符号：byte,uint,ulong,ushort
            //有符号：sbyte,int,long,short
            //浮点：float,double
            //特殊：bool,char,string

            //2.复杂数据容器
            //枚举 enum
            //结构体
            //数组（一维，二维，交错）（[],[,],[][]）
            //类

            //3.数据集合
            //ArrayList
            //Stack
            //Queue
            //HashTable
            //这些本质都是object数组


            //3.泛型数据集合
            //List
            //Dictionary
            //LinkedList
            //Stack泛型栈
            //Queue泛型队列

            #endregion


            //泛型栈和队列
            Stack<int> st = new Stack<int>();
            Queue<string> Qu = new Queue<string>();
            
        }
    }
}
