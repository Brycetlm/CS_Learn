using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack本质
            //stack是一个c#封装好的类，本质也是object数组，只是封装了特殊的存储规则
            //也就是说c#中的stack是使用object实现的
            //先进后出，先存进去的数据后获取


            //声明
            Stack st = new Stack();


            //增取改查
            //1.增，压栈
            st.Push(100);
            st.Push("fghjkl");
            st.Push(8963);
            st.Push(10550);
            st.Push(1080);
            //2.取，弹栈
            //因为push和pop都是一个元素一个元素的进行，所以这里的pop并没有任何参数，直接弹出栈顶的值
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            //3.查
            //栈只能查看栈顶的值，无法查看指定内容
            //pop是从容器里移出去，peek只是看看没有移除
            Console.WriteLine(st.Peek());
            //3.1查看是否存在于栈中
            Console.WriteLine("查看是否存在："+st.Contains(100));

            //改
            //很难改，只能弹和压
            //可以清空st.Clear();


            //遍历
            //获得长度st.Count();
            //!!!因为不能通过下标访问，所以不能用for循环遍历stack
            //foreach遍历
            Console.WriteLine("foreach遍历");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            //将栈转换为数组再遍历 用ToArray函数
            object starr = st.ToArray();

            //循环弹栈
            Console.WriteLine("循环弹栈");
            while (st.Count>0)
            {
                Console.WriteLine(st.Pop());
            }


            //拆箱装箱


            Console.ReadLine();
        }
    }
}
