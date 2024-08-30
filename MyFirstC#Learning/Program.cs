using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstC_Learning
{
    class Rectangle
    {
       private double length, width;

        public void AcceptInputs()
        {
            Console.Write("Enter the Length: ");
            length = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the Width: ");
            width = Convert.ToInt64(Console.ReadLine());

        }
        public double CalculateArea()
        {
            return length * width;
        }

        public void DisplayAnswer() {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {CalculateArea(): 0.00}");
        }

        public void ExecuteArea()
        {
            AcceptInputs();
            CalculateArea();
            DisplayAnswer();
        }
    }

    class Square
    {
        private double length, width;

        public void AcceptInputs()
        {
            Console.Write("Enter the Length: ");
            length = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the Width: ");
            width = Convert.ToInt64(Console.ReadLine());

        }
        public double CalculateArea()
        {
            return length * width;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Area: {CalculateArea(): 0.00}");
        }

        public void ExecuteArea()
        {
            AcceptInputs();
            CalculateArea();
            DisplayAnswer();
        }
    }

    class Circle
    {
        private double radius;
       

        public void AcceptInputs()
        {
            Console.Write("Enter the Radius: ");
            radius = Convert.ToInt64(Console.ReadLine());

        }
        public double CalculateArea()
        {
            return Math.PI * (Math.Pow(radius,2));
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {CalculateArea(): 0.00}");
        }

        public void ExecuteArea()
        {
            AcceptInputs();
            CalculateArea();
            DisplayAnswer();
        }
    }
    class ExecuteArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SELECT YOUR SHAPE:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Rectangle r = new Rectangle();
                    r.ExecuteArea();
                    break;
                case 2:
                    Square s = new Square();
                    s.ExecuteArea();
                    break;
                case 3:
                    Circle c = new Circle();
                    c.ExecuteArea();
                    break;
                default:
                    Console.WriteLine("No option selected");
                    break;

            }

            Console.ReadLine();
        }
    }
}
