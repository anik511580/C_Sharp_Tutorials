using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());

            Console.ReadLine();

        }
    }

    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This color is " + color;

        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
