using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue是cs封装好的类
            //先进先出
            //本质也是object数组

            //声明
            Queue qe = new Queue();

            //增取查改
            //1.增加，进队
            qe.Enqueue(1);
            qe.Enqueue("hjkjkkj");
            qe.Enqueue(654);

            //2.取出
            qe.Dequeue();  //因为是按照顺序挨个来 所以不存在参数

            //3.查
            //3.1查看队列头元素但不取出
            qe.Peek();
            //3.2查看是否存在元素
            qe.Contains(1);
            

            //4.改
            //无法直接改

            //遍历
            //foreach遍历或者转换为object数组后遍历
            //循环出列


            //拆箱装箱
        }
    }
}
