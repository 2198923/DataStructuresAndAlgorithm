using System;

namespace Calculation12
{
    class MainClass
    {
        public static void Main(string[] args)         {             int a, b, c;//a代表公鸡的数量，b代表母鸡的数量，c代表小鸡的数量             for (a = 0; a < 100; a++)//公鸡                 for (b = 0; b < 100; b++)//母鸡                     for (c = 0; c < 100; c++)//小鸡                         if (a + b + c == 100 && a * 5 + b * 3 + c * 1 / 3 == 100)//判断3种鸡的总数等于100的同时总价格等于100                             if (c % 3 == 0)//判断小鸡数量能否被3整除                                 Console.WriteLine("公鸡={0}只,母鸡={1}只,小鸡={2}只", a, b, c);//上面的判断都完成后输出结果
        }
    }
}
