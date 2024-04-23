using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afu_homework02_2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("請輸入您的成績:");

            try
            {
                double score = double.Parse(Console.ReadLine());
                string grade;
                if (score >= 90 && score <= 100)
                {
                    grade = "A";
                }
                else if (score >= 80 && score < 90)
                {
                    grade = "B";
                }
                else if (score >= 70 && score < 80)
                {
                    grade = "C";
                }
                else if (score >= 60 && score < 70)
                {
                    grade = "D";
                }
                else if (score >= 0 && score < 60)
                {
                    grade = "E";
                }
                else if (score > 100 || score < 0)
                {
                    Console.WriteLine("請輸入 0-100 的數字！");
                    return;
                }
                else
                {
                    Console.WriteLine("您輸入了非數字！");
                    return;
                };

                switch (grade)
                {
                    case "A":
                        Console.WriteLine($"您的成績:{score}為{grade}級");
                        break;
                    case "B":
                        Console.WriteLine($"您的成績:{score}為{grade}級");
                        break;
                    case "C":
                        Console.WriteLine($"您的成績:{score}為{grade}級");
                        break;
                    case "D":
                        Console.WriteLine($"您的成績:{score}為{grade}級");
                        break;
                    case "E":
                        Console.WriteLine($"您的成績:{score}為{grade}級");
                        break;


                }
            }
            catch (Exception)
            {
                Console.WriteLine("您輸入了非數字！");

            }

        }
    }



}