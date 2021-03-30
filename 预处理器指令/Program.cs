//#define Unity4
#undef Unity4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//表示如果满足if条件，那么里面的代码会被编译
#if Unity4
Console.WriteLine();
#endif

namespace 预处理器指令
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么是编译器

            //什么是预处理器指令

            //常见的预处理器指令
            //1.#define
            //定义一个符号，类似一个没有值的变量
            //#undef
            //取消#define定义的符号，让其失效
            //一般配合if使用

            //2.
            //#if
            //#elif
            //#else
            //#endif
            //和if语句规则一样
            //用于告诉编译器进行编译代码的流程控制，例如版本不同时，某些代码不会生效，可以用预处理器指令先规定
            

            //3.
            //告诉编译器是报警告还是错误
            //#waring
            //#error
            //配合if使用。例如警告这个版本不合法，或者直接报错


        }
    }
}
