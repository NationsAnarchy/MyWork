using System;
namespace MyConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type in a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("The century is: " + FindCenturyFromYear(year));
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.Write("Nhập vào số a: ");
            var a = decimal.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Nhập vào số b: ");
            var b = decimal.Parse(Console.ReadLine() ?? string.Empty);
            var tong = a + b;
            var hieu = a - b;
            var tich = a * b;
            var thuong = a / b;
            var du = a % b;
            Console.WriteLine($"Phép cộng a và b là: {tong}");
            Console.WriteLine($"Phép trừ a và b là: {hieu}");
            Console.WriteLine($"Phép nhân a và b là: {tich}");
            Console.WriteLine($"Phép chia a và b là: {decimal.Round(thuong, 2)}");
            Console.WriteLine($"Phép lấy dư a và b là: {du}");
            Console.WriteLine(SquareExpand(5));
            Console.WriteLine(NumberCompare(6,5));
        }

        /// <summary>
        /// Hàm tính ra thế kỉ theo năm nhập vào trước
        /// </summary>
        /// <param name="year">Năm nhập vào dạng số</param>
        /// <returns>Trả lại thế kỉ</returns>
        private static int FindCenturyFromYear(int year) => (year - 1) / 100 + 1;

        private static double SquareExpand(int square)
        {
            if (square < 2) return 0;
            return Math.Pow(square, 2) + Math.Pow((square - 1), 2);
        }

        private static bool NumberCompare(int a, int b) => a <= b;
    }
}