using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1------------------------------------------------------------------
            Console.WriteLine("Task 1");
            Console.WriteLine("\n");
            Console.WriteLine("Compare Two Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) 
            {
                Console.WriteLine($"The bigger number is {num1}");
            }
            else 
            {
                Console.WriteLine($"The bigger number is {num2}");
            }
            //Task 2------------------------------------------------------------------
            Console.WriteLine("Task 2");
            Console.WriteLine("\n");
            Console.WriteLine("What is the sign of this number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            //Task 3------------------------------------------------------------------
            Console.WriteLine("Task 3");
            Console.WriteLine("\n");
            Console.WriteLine("Sort Numbers");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            if (num4 > num5 && num4 > num6)
            {
                if (num5 > num6)
                {
                    Console.Write($"{num4},{num5},{num6}");
                }
                else
                {
                    Console.Write($"{num4},{num6},{num5}");
                }
            }
            else if(num5> num6 && num5 >num4)
            {

                if (num4 > num6)
                {
                    Console.Write($"{num5},{num4},{num6}");
                }
                else
                {
                    Console.Write($"{num5},{num6},{num4}");
                }
            }
            else if (num6 > num5 && num6 > num4)
            {

                if (num5 > num4)
                {
                    Console.Write($"{num6},{num5},{num4}");
                }
                else
                {
                    Console.Write($"{num6},{num4},{num5}");
                }
            }
            Console.WriteLine("\n");
            //Task 4------------------------------------------------------------------
            Console.WriteLine("Task 4");
            Console.WriteLine("\n");
            Console.WriteLine("What is the Biggest Number");
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());
            int num9 = Convert.ToInt32(Console.ReadLine());
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = Convert.ToInt32(Console.ReadLine());
            if (num7 > num8 && num7 > num9 && num7 > num10 && num7 > num11)
            {
                Console.WriteLine($"The biggest number is {num7}");
            }
            else if (num8 > num7 && num8 > num9 && num8 > num10 && num8 > num11)
            {
                Console.WriteLine($"The biggest number is {num8}");
}
            else if (num9 > num7 && num9 > num8 && num9 > num10 && num9 > num11)
                        {
                Console.WriteLine($"The biggest number is {num9}");
            }
            else if (num10 > num7 && num10 > num8 && num10 > num9 && num10 > num11)
            {
                Console.WriteLine($"The biggest number is {num10}");
            }
            else if (num11 > num7 && num11 > num8 && num11 > num9 && num11 > num10)
            {
                Console.WriteLine($"The biggest number is {num11}");
            }
            //Task 5---------------------------------------------------------------
            Console.WriteLine("Task 5");
            Console.WriteLine("\n");
            Console.WriteLine("Convert from km to miles");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = (double)(km/1.6);
            Console.WriteLine(miles);
            //Task 6---------------------------------------------------------------
            Console.WriteLine("Task 6");
            Console.WriteLine("\n");
            Console.WriteLine("Convert from hours to minutes");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int sum = (int)(hours*60 + minutes);
            Console.WriteLine(sum);
            //int sum2 = (int)(hours/60 + minutes*60);
            //Console.WriteLine(sum2); 
            //Task7----------------------------------------------------------------
            Console.WriteLine("Task 6");
            Console.WriteLine("\n");
            string[] name = { "Razan", "Momen", "Amer", "Qais", "Sawalha","Yazeed"};
            Console.WriteLine(name[0].Substring(0, 3));
            Console.WriteLine(name[1].Substring(0, 3));
            Console.WriteLine(name[2].Substring(0, 3));
            Console.WriteLine(name[3].Substring(0, 3));
            Console.WriteLine(name[4].Substring(0, 3));
            Console.WriteLine(name[5].Substring(0, 3));

        }
    }
}
