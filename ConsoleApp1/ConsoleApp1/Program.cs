using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afu_homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            string str_message = "";

            while (true)
            {
                Console.WriteLine("請輸入您的成績:");
                str_message = "";

                try
                {
                    score = (int)Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("您輸入了非數字！");
                    continue;
                }

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
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("您輸入了非數字！");
                        continue;
                    };

                        str_message = "";
                        switch (grade)
                        {
                            case "A":
                                str_message = $"您的成績:{score}";
                                break;
                            case "B":
                                str_message = $"您的成績:{score}為{grade}級";
                                break;
                            case "C":
                                str_message = $"您的成績:{score}為{grade}級";
                                break;
                            case "D":
                                str_message = $"您的成績:{score}為{grade}級";
                                break;
                            case "E":
                                str_message = $"您的成績:{score}為{grade}級";
                                break;
                        }

            if (!string.IsNullOrEmpty(str_message))
            {
                Console.WriteLine(str_message);
                
                break;
            }
            }
        }
    }
}