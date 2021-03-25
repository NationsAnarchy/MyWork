using System;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first C# program!");
            Console.WriteLine("Insert number a: ");
            var a = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Insert number b: ");
            var b = int.Parse(Console.ReadLine() ?? string.Empty);
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Please use a different number than 0.");
            }
            else
            {
                Calculation(a, b);
                GeometryCalculator(a, b);
            }
        }

        private static void Calculation(int a, int b)
        {
            var sum = a + b;
            var minus = a - b;
            var multiply = a * b;
            
            if (b != 0)
            {
                Console.WriteLine("Sum of a and b is: " + sum);
                Console.WriteLine("Minus of a and b is: " + minus);
                Console.WriteLine("Multiply of a and b is: " + multiply);
                var degrade = a / b;
                var modulo = a % b;
                Console.WriteLine("Degrade of a and b is: " + degrade);
                Console.WriteLine("Modulo result is: " + modulo);
            }

            else
            {
                Console.WriteLine("Sum of a and b is: " + sum);
                Console.WriteLine("Minus of a and b is: " + minus);
                Console.WriteLine("Multiply of a and b is: " + multiply);
            }
        }

        private static void GeometryCalculator(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Not a valid data for geometry calculation");
            }

            else
            {
                var square = a * a;
                var rectangle = a * b;
                Console.WriteLine("Square: " + square);
                Console.WriteLine("Rectangle: " + rectangle);
            }
        }
    }
}