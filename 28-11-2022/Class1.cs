using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_2022
{

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
       
        public void Engine() 
        {
            string flag = Console.ReadLine();
            if (flag == "b") 
            { 
            Console.WriteLine("Vroom Vroom");
            
            }
            else if (flag == "r") 
            {

                Console.WriteLine("The engine has stopped");
                
                    
            }
            else 
            {
                Console.WriteLine("Pleas type b or r to start engine");
            }
        }
    }
    class Car2
    {
        public string type = "Sedan";
        public string year = "2022";
        public string price = "32,000";
        

    }
    class  BMW : Car2
    {
       
        public string label = "Ford";
        public string Model = "Fusion";
        public string PalletNO = "999";
    }

}   
