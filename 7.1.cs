using System;

namespace _7._1
{
    public class Circle
    {
        double rad;
        String[] color = { "Black", "White", "Red", "Blue", "Grey", "Yellow", "Orange", "Green", "Brown", "Purple" };
        string figureColor;
        private string name = "Circle";
        double perimetr;
        double area;
        public void setCircle()
        {
            Console.WriteLine("Please enter radius");
            string sRad = Console.ReadLine();
            rad = double.Parse(sRad);
        }
        public void getColor()
        {
            Random rnd = new Random();
            int rndColor = rnd.Next(0, 9);
            figureColor = color[rndColor];
        }
        public void getCircle()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Color = " + figureColor);
            perimetr = 2 * Math.PI * rad;
            area = Math.PI * rad * rad;
            Console.WriteLine("Perimetr = " + perimetr);
            Console.WriteLine("Area = " + area);
            Console.WriteLine();
        }
    }
    public class Square
    {
        int size;
        String[] color = { "Black", "White", "Red", "Blue", "Grey", "Yellow", "Orange", "Green", "Brown", "Purple" };
        string figureColor;
        private string name = "Square";
        int perimetr;
        int area;
        public void setSquare()
        {
            Console.WriteLine("Please enter size");
            string sSize = Console.ReadLine();
            size = int.Parse(sSize);
        }
        public void getColor()
        {
            Random rnd = new Random();
            int rndColor = rnd.Next(0, 9);
            figureColor = color[rndColor];
        }
        public void getSquare()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Color = " + figureColor);
            perimetr = 4 * size;
            area = size * size;
            Console.WriteLine("Perimetr = " + perimetr);
            Console.WriteLine("Area = " + area);
            Console.WriteLine();
        }
    }
    public class Triangle
    {
        Double[] size = new double[3];
        String[] sSize = new string[3];
        String[] color = { "Black", "White", "Red", "Blue", "Grey", "Yellow", "Orange", "Green", "Brown", "Purple" };
        string figureColor;
        private string name = "Triangle";
        double perimetr;
        double polperimetr = 0;
        Boolean check = true;
        double area;
        public void setTriangle()
        {
            for(int i = 0; i < size.Length; i++)
            {
                Console.WriteLine("Please enter size[" + (i+1) + "] ");
                sSize[i] = Console.ReadLine();
                size[i] = double.Parse(sSize[i]);
                polperimetr += size[i] / 2;
            } 
            for(int i=0; i < size.Length; i++)
            {
                if (size[i] >= polperimetr)
                {
                    check = false;
                }
            }
        }
        public void getColor()
        {
            Random rnd = new Random();
            int rndColor = rnd.Next(0, 9);
            figureColor = color[rndColor];
        }
        public void getTriangle()
        {
            if (check)
            {
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Color = " + figureColor);
                perimetr = size[1] + size[2] + size[3];
                area = Math.Sqrt(polperimetr * (polperimetr - size[1]) * (polperimetr - size[2]) * (polperimetr - size[3]));
                Console.WriteLine("Perimetr = " + perimetr);
                Console.WriteLine("Area = " + area);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Have no triangle");
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();
            Boolean flag = true;            
            for (; ; )
            {
                Console.WriteLine("Please enter figure:");
                Console.WriteLine("Circle - 1, Square - 2, Triangle - 3, Exit - 0");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        circle.setCircle();
                        circle.getColor();
                        circle.getCircle();
                        break;
                    case "2":
                        square.setSquare();
                        square.getColor();
                        square.getSquare();
                        break;
                    case "3":
                        triangle.setTriangle();
                        triangle.getColor();
                        triangle.getTriangle();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please make your choise");
                        break;
                }
                if(flag == false)
                {
                    break;
                }
            }
        }
    }
}
