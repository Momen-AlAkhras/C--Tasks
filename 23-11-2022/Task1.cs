using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Input your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);


            Console.WriteLine("Task 2");
            int number = 0;
            string name2 = "John";
            double dec = 0.56;
            char b = 'b';
            bool yay = true;
            const char t = 'a';
            Console.WriteLine(number);
            Console.WriteLine(name2);
            Console.WriteLine(dec);
            Console.WriteLine(b);
            Console.WriteLine(yay);
            Console.WriteLine(t);


            Console.WriteLine("Task 3");
            string[] cars = { "Volvo", "Fiat", "Hyundai" };
            Console.WriteLine(cars[1]);

            Console.WriteLine("Task 4");
            Console.WriteLine("Input your Details");
            Console.Write("Name:"); string fname = Console.ReadLine();
            Console.Write("Age:"); string Age = Console.ReadLine();
            Console.Write("Uni:"); string Uni =Console.ReadLine();
            Console.Write("Major:"); string Major = Console.ReadLine();
            Console.WriteLine(fname); Console.WriteLine(Age); Console.WriteLine(Uni); Console.WriteLine(Major);

            Console.WriteLine("Task 5");
            string[] num = new string[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Console.ReadLine();
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            string[] num2 = new string[3];
             for (int i =0; i < num2.Length; i++)
            {
                num2[i] = Console.ReadLine();
            }
            string sum = num2[0] + num2[1] + num2[2];
            Console.WriteLine(sum);

        }


    }
}
