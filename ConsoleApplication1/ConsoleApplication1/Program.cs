using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("red");
            Console.WriteLine(car.Describe());

            car = new Car("blue");
            Console.WriteLine(car.Describe());

            Console.ReadLine();


        }

        class Car
        {
            private string color; 
        
            public Car (String color)
            {
                this.color = color;
            }
            
        

            public string Describe()
            {
            
                return "this color is" + Color;
            }

            public string Color {
                get { return color; }

                set { color = value; }
            }
        }
    }
}
