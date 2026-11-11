using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Диапазоны целочисленных типов:");
            Console.WriteLine($"sbyte: {sbyte.MinValue} .. {sbyte.MaxValue}");
            Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");
            Console.WriteLine();

            Console.WriteLine("Диапазоны дробных типов:");
            Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");
            Console.WriteLine();

            Console.WriteLine("Переполнение:");
            byte b = 255;
            Console.WriteLine($"byte до: {b}");
            b++;
            Console.WriteLine($"byte после: {b}");

            int max = int.MaxValue;
            Console.WriteLine($"int до: {max}");
            max++;
            Console.WriteLine($"int после: {max}");
            Console.WriteLine();
        }
    }
}
