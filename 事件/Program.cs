using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    #region 事件定义
    //事件是基于委托的存在
    //事件是委托的包裹，让委托的使用更安全
    //事件是一种特殊的变量类型

    #endregion

    #region 事件的使用
    //访问修饰符 event 委托类型 事件名;

    //事件作为成员变量存在于类中，或者接口和结构体中
    //委托怎么用，事件就怎么用
    
    //事件和委托的区别
    //《事件不能在类外部赋值》
    //《事件不能在类外部调用》《即不能用invoke或者直接()调用》
    //《事件只能用+=和-=，不能用=》《即事件不可以在外部赋值，但是能加减》
    //所以事件更安全

    //所以他只能作为成员存在于类、结构体和接口中
    #endregion

    #region 为什么要用事件
   //防止外部置空或者随意调用委托
   //事件相当于对委托进行了一次封装，使其更加安全

    #endregion


    class Test
    {
        //委托成员变量 用于存储函数
        public Action ac;

        //事件成员变量 用于存储函数，事件声明就比委托多了一个event
        public event Action ac2;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
