using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.字符串指定位置的获取
            //字符串的本质就是一个char数组
            //string里是有索引器的
            string str = "TLMPP";
            Console.WriteLine(str[0]);  //输出T
            //也可以把string转为char数组
            char[] cha = str.ToCharArray();    //也可以将string转为char数组
            //《注意》string类型是不能通过索引来修改字符的，是只读类型,但是StringBuilder可以
            //str[0] = "0";

            //2.字符串拼接
            str = string.Format("{0}{1}{2}", str, 5696,"SDLOP");
            Console.WriteLine(str);

            //3.正向查找字符位置
            //通过字符找到字符位置
            Console.WriteLine(str.IndexOf("T"));//0
            Console.WriteLine(str.IndexOf("LM"));//也可以找长字符串 ，返回首字符位置
            //如果没有这个字符，返回-1

            //4.反向查找字符位置
            //找的时候从后往前找
            //但字符顺序是不变的，例如QLKO，不会按照OKLQ的顺序找
            Console.WriteLine(str.LastIndexOf("LM"));  //1
            Console.WriteLine(str.LastIndexOf("ML"));  //找不到，也就是字符串顺序不是倒序的

            //5.移除指定位置后的《所有》字符
            //!!!注意，string方法中很多都不会改变原字符串，而是返回一个新字符串
            string str2 = "01234";
            str2.Remove(0);  //这里虽然remove了，但是str2还是没变，只是会返回一个新string
            Console.WriteLine(str2);  //还是01234
            Console.WriteLine(str2.Remove(3));  //这里返回012
            //5.1两个参数的remove，（开始字符，移除个数）
            str2 = "0123456";
            Console.WriteLine(str2.Remove(3,3));  //0126


            //6.替换指定字符
            //!!同样的，它不会直接替换原string。而是返回一个新string
            str2.Replace("012", "PPP");
            Console.WriteLine(str2);   //0123456
            Console.WriteLine(str2.Replace("012", "PPP"));  //PPP3456
            Console.WriteLine(str2.Replace("000", "PPP"));  //如果OldValue不存在，那就不替换

            //7.大小写转换
            //!!同样的，它不会直接替换原string。而是返回一个新string
            string str3 = "ASDFhjk";
            str3.ToUpper();
            Console.WriteLine(str3);
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str3.ToLower());

            //8.字符串截取
            //!!同样的，它不会直接替换原string。而是返回一个新string
            Console.WriteLine(str3.Substring(2));  //DFhjk
            Console.WriteLine(str3.Substring(2,2)); //DF
            //如果超出长度会报错
            //Console.WriteLine(str3.Substring(2, 80));

            //9.字符串切割
            //很重要！因为可以通过,等符号将数据切分开
            //还有很多其他重载
            string str5 = "1,2,3,4,5,6";
            string[] strs = str5.Split(',');   //《注意》这里是单引号，因为是char类型
            for(int i=0;i<strs.Length;i++)
            {
                Console.WriteLine(strs[i]);
            }

            

            Console.ReadLine();
        }
    }
}
