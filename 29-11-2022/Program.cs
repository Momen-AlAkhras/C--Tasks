using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;


namespace R{

    abstract class Employee
    {
        public string name { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public Employee(string name, int date,int id)
        {
            this.name = name;
            this.date = date;
            this.id = id;
        }
        public abstract void Complain();
    }
    class Manager : Employee
    {
        public Manager(string name, int date, int id) : base(name, date, id)
        {

        }
        public override void Complain()
        {
            Console.WriteLine("Blah Blah");
        }
    }
    class Car
    {
        public string type = "Sedan";
        public string year = "2022";
        public string price = "32,000";
        public string label = "Ford";
        public string Model = "Fusion";
        public string PalletNO = "999";

        public Car(string type, string year, string price, string label, string model, string PalletNO)
        {
            this.type = type;
            this.year = year;
            this.price = price;
            this.label = label;
            this.PalletNO = PalletNO;
            this.Model = model;


        }
    }
    class Program {
    static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int date = Convert.ToInt32(Console.ReadLine());
            int id = Convert.ToInt32(Console.ReadLine());
            Manager emp = new Manager(name,date,id);
            Console.WriteLine(emp.name);
            if (date > 2022 || date > 2004)
            {
                Console.WriteLine("Invalid date");

            }
            else 
            {
                int age = 2022 - date;
                Console.WriteLine(age);
            }
            Console.WriteLine(id);
            emp.Complain();
        }
    }
}

