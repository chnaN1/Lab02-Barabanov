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

            Console.WriteLine("Тип char:");
            char letter = 'A';
            char digit = '7';
            char cyrillic = 'Ж';
            Console.WriteLine($"letter = {letter}, код = {(int)letter}");
            Console.WriteLine($"digit = {digit}, код = {(int)digit}");
            Console.WriteLine($"cyrillic = {cyrillic}, код = {(int)cyrillic}");
            Console.WriteLine($"char.IsLetter('A') = {char.IsLetter(letter)}");
            Console.WriteLine($"char.IsDigit('7') = {char.IsDigit(digit)}");
            Console.WriteLine($"char.ToUpper('a') = {char.ToUpper('a')}");
            Console.WriteLine($"char.ToLower('Я') = {char.ToLower('Я')}");
            Console.WriteLine("Первая строка\nВторая строка");
            Console.WriteLine("Табуляция:\tмежду\tсловами");
            Console.WriteLine("Кавычки: \"текст в кавычках\"");
            Console.WriteLine("Обратный слэш: C:\\temp");
            Console.WriteLine("Юникод: \u00A9 \u20BD");
            Console.WriteLine();

            Console.WriteLine("decimal и double:");
            Console.WriteLine($"double: {0.1 + 0.2}");
            Console.WriteLine($"decimal: {0.1m + 0.2m}");

            decimal price = 199.99m;
            int count = 3;
            Console.WriteLine($"Стоимость: {price * count:F2} руб.");
            Console.WriteLine();
        }
    }
}
