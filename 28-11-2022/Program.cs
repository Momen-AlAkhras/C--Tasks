using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _28_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Sedan","2022","32,000","Ford","Fusion","33");
            Console.WriteLine(car.type);
            Console.WriteLine(car.year);
            Console.WriteLine(car.price);
            Console.WriteLine(car.label);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.PalletNO);
            car.Engine();
            BMW car2 = new BMW();
            Console.WriteLine(car2.type);
            Console.WriteLine(car2.year);
            Console.WriteLine(car2.price);
            Console.WriteLine(car2.label);
            Console.WriteLine(car2.Model);
            Console.WriteLine(car2.PalletNO);


        }
    }
}
