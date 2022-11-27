using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_2022
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //Task 1 -----------------------------------------------------------------------
            int[] arr = { 1, 79, 45, };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "The", "Fox", "Over" };
            //Task 2 ----------------------------------------------------------------------
            Console.WriteLine("Task 2");
            Console.WriteLine("\n");
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            //Task 3 ----------------------------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 3");
            string[] favfood = { "Pizza", "Shawerma", "Chimcken", "C#", "Bannan" };
            string[] favsport = { "Football", "Basketball", "Esports" };
            string[] favmovies = { "Spirited Away", "your name", "Ponyo", "Castle in the sky" };
            Console.WriteLine("My fav foods are:");
            Console.ReadLine();
            foreach (string food in favfood)
            {
               Console.WriteLine(food);
            }
            Console.WriteLine("My fav Sports are:");
            Console.ReadLine();
            for (int i=0;i <favsport.Length;i++)
            {
                Console.WriteLine(favsport[i]);
            }
            Console.WriteLine("My fav Movies are:");
            Console.ReadLine();
            for (int i = 0; i < favmovies.Length; i++)
            {
                Console.WriteLine(favmovies[i]);
            }
            //Task 4 ----------------------------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 4");
            Console.WriteLine("Input three numbers separated by comma: ");
            string number = Console.ReadLine();
            string[] num = number.Split(',');

            Console.WriteLine(Convert.ToInt32(num[0]) + Convert.ToInt32(num[1]) + Convert.ToInt32(num[2]));
            //Task 5 ----------------------------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 5");
            int sum = 0;
            for (int i =0; i < 100; i++)
            {
                Console.Write(i + "\t");
                if (i % 2 !=0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The sum is : {sum}");
            //Task 6 -------------------------------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 6");
            for (int i =0; i< 5; i++)
            {
                for (int j=0; j< i; j++)
                {
                    Console.Write("\t *");
                }
                Console.WriteLine();
            }
            //Task  7-------------------------------------------------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 7");
            int sum2 = 1;
            for (int i = 0; i < 4; i++)
            {
               
                for (int j = 0; j <= i; j++)
                {
                    
                    Console.Write("\t" + sum2++);
                }
                Console.WriteLine();
            }
       
        }
    }
    }

