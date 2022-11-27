using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static double SumAvg(double[] d)
        {
            double sum = 0;
            for (int i=0; i < d.Length; i++)
            {
                sum += d[i];
            }

            return sum;
           
           
        }
        static int SumCube(int d)
        {
            return d * d * d;
        }
        static void Years(int[] d)
        {
          for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > 1950)
                {
                   Console.WriteLine(d[i]);
                }
               
            }
        }
        static int yearstodays(int d)
        {
            return d * 365;
        }
        static int Farm(int chicken,int pigs,int cow)
        {
            if (chicken % 2 == 0)
            {
                return chicken * 2;
            }
           
            if (pigs % 2 ==0)
            { 
                return pigs * 4;
            }
       
            if (cow % 2 ==0)
            {
                return cow * 4;
            }
            return chicken;
        }
        static void login(string username,string password)
        {
            if (username == "Momen" && password == "Momen")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }
        static int power(int d, int p)
        {
            int sum2 =d;
            for (int i=0; i<p-1; i++)
            { 
                sum2 = d*sum2 ;

            }
            return sum2;
        }
        static void leap(int year)
        {
            if (year > 2024 || year < 1900) Console.WriteLine("invalid year");
            else if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    { Console.WriteLine("This is a leap year"); }
                    else Console.WriteLine("This is not a leap year");
                }
                else Console.WriteLine("This is a leap year");

            }
            else
            {
                Console.WriteLine("Not a leap year");
            }


        }
        static void prime(int d) 
        {
            string l = "not a prime number";
            if (d % 2== 0 && d !=2)
            {
                Console.WriteLine(l);

            }
            else if (d % 3 ==0 && d != 3)
            {
                Console.WriteLine(l);
            }
            else if (d % 5 ==0 && d != 5)
            {
                Console.WriteLine(l);
            }
            else if (d % 7 ==0 && d!= 7)
            { 
                Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine(d);
            }
        }
        static int scentence(string sentence)
        {
            string[] slicer = sentence.Split(' ');
            int counter = 0;
            foreach (string s in slicer)
                counter++;

            return counter;
        }
        static void Main(string[] args)
        {
            double[] doubles = { 2, 2, 2, 2, 2, 2, 2, 2, 2, };
            Console.WriteLine(SumAvg(doubles));
            Console.WriteLine(SumAvg(doubles)/doubles.Length);
            Console.WriteLine(SumCube(3));
            int[] amer = { 1960, 1970, 1800, 1600, 1700, 1840 };
            Years(amer);
            Console.WriteLine(yearstodays(3));
            Console.WriteLine(Farm(6,4,6));
            login("Momen", "Momen");
            Console.WriteLine(power(4,3));
            leap(1998);
            prime(89);
            Console.WriteLine(scentence("Momen is nice and very good at coding"));
        }
        
    }
}