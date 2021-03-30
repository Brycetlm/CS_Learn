using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StringBuilder相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#提供的用于处理字符串的公共类
            //主要解决的问题是：
            //修改字符而不创建新字符，减少内存消耗
            //使用时需要引用namespace,using System.Text;
            StringBuilder str = new StringBuilder("5555556660ssssssss0066");
            Console.WriteLine(str);

            //StringBuilder改完之后不需要用新的变量承接，意思就是它是真的在原字符串上修改
            //StringBuilder里也没有indexof方法也就是没有查找字符位置



            //容量Capacity
            //stringbuilder存在容量，每次新增内容会自动扩容
            Console.WriteLine(str.Capacity);   //这个容量是大于字符串长度的，而且会根据字符串长度自动扩容

            //增加
            //不能用str+="55"
            //要用追加的方法
            str.Append("sjsk");
            Console.WriteLine(str);
            str.AppendFormat("{0}{1}", "ss", "uj");
            Console.WriteLine(str);
            //str.AppendLine();
            //Console.WriteLine(str);


            //插入
            str.Insert(0, "插入");
            Console.WriteLine(str);

            //删除
            str.Remove(1, 1);
            Console.WriteLine(str);

            //清空
            //str.Clear()


            //查询和改某一个字符
            //string类型不行，StringBuilder可以
            str[0] = '改';   //注意单引号
            Console.WriteLine(str);

            //替换
            str.Replace("改", "替换");
            Console.WriteLine(str);


            //重新赋值
            //先清空在重新加东西
            //str.Clear();str.Append("5554554");

            //判断相等，直接用==是不行的，可以用object里面的Equals方法，当然是StringBuilder重写过的
            //if(str=="566")
            //{

            //}
            StringBuilder str2 = new StringBuilder("7899");
            Console.WriteLine(str.Equals("gaisss"));
            Console.WriteLine(str.Equals(str2));



            Console.ReadLine();


        }
    }
}
