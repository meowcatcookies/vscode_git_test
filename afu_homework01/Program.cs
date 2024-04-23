using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afu_homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入成績(0-100的數字)");
            string sc = Console.ReadLine();
            int i = 0; ;
            bool result = int.TryParse(sc, out i);
            if (result == true)
            {
                double score = Convert.ToDouble(sc);
                if (score >= 90 && score <= 100) { Console.WriteLine("你的成績是" + score + "等級為A"); }
                else if (score >= 80) { Console.WriteLine("你的成績是" + score + "等級為B"); }
                else if (score >= 70) { Console.WriteLine("你的成績是" + score + "等級為C"); }
                else if (score >= 60) { Console.WriteLine("你的成績是" + score + "等級為D"); }
                else if (score >= 0 && score < 60) { Console.WriteLine("你的成績是" + score + "等級為E"); }
                else { Console.WriteLine("請輸入正確成績"); }
            }
            else
            {
                Console.WriteLine("「您輸入了非數字！」");

            }


        }
        }
    }
}