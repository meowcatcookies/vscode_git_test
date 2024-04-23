using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afu_homework02
{
    internal class Program
    {
        static void ninenine(string s)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int ij = i * j;
                    if (ij < 10)
                    {
                        Console.Write(($"{j}*{i}={s}{ij}\t"));
                    }
                    else
                    {
                        Console.Write(($"{j}*{i}={ij}\t"));
                    }

                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            //1.基礎級
            
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int ij = i * j;

                    var Str = ij.ToString().PadLeft(2, ' ');

                    string s = ($"{j}*{i}={Str}\t");
                    Console.Write(s);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            //2.實用級(String.Format、$格式化)
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int ij = i * j;
                    var Str = String.Format("{0,2}", ij);
                    
                    string s = ($"{j}*{i}={Str}\t");
                    Console.Write(s);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int ij = i * j;
                    if (ij < 10)
                    {
                        Console.Write(($"{j}*{i}= {ij}\t"));
                    }
                    else
                    {
                        Console.Write(($"{j}*{i}={ij}\t"));
                    }                  
                    
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            //3.進階級：對齊部份使用任意一種皆可，但應使用自定方法回傳一個string，再顯示。

            ninenine(" ");

        }
    }
}

