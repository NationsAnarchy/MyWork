using System;

namespace MyConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Testing Git repo on my own.");
            Console.WriteLine();
            
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Looping for fun xDD");
            }

            Console.Write("Nhập vào số a: ");
            decimal a = decimal.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Nhập vào số b: ");
            decimal b = decimal.Parse(Console.ReadLine() ?? string.Empty);

            decimal tong = a + b;
            decimal hieu = a - b;
            decimal tich = a * b;
            decimal thuong = a / b;
            decimal du = a % b;
            
            Console.WriteLine($"Phép cộng a và b là: {tong}");
            Console.WriteLine($"Phép trừ a và b là: {hieu}");
            Console.WriteLine($"Phép nhân a và b là: {tich}");
            Console.WriteLine($"Phép chia a và b là: {decimal.Round(thuong, 3)}");
            Console.WriteLine($"Phép lấy dư a và b là: {du}");
        }
    }
}