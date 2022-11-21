using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args) { 
        string fname = Console.ReadLine();
        string lname = Console.ReadLine();
        string name = $"My full name is {fname} {lname}";
        Console.WriteLine(name);
        }
    }
}
