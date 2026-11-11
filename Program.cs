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

            Console.WriteLine("var:");
            var studentAge = 20;
            var studentName = "Иван";
            var pi = 3.14;
            Console.WriteLine($"studentAge: {studentAge.GetType().Name}");
            Console.WriteLine($"studentName: {studentName.GetType().Name}");
            Console.WriteLine($"pi: {pi.GetType().Name}");
            Console.WriteLine();

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Введите вашу группу: ");
            string group = Console.ReadLine() ?? "";
            Console.WriteLine($"Привет, {name}! Группа: {group}.");
            Console.WriteLine();

            Console.Write("Введите год рождения: ");
            string yearText = Console.ReadLine() ?? "";
            int yearConvert = Convert.ToInt32(yearText);
            int yearParse = int.Parse(yearText);
            Console.WriteLine($"Convert.ToInt32: {yearConvert}");
            Console.WriteLine($"int.Parse: {yearParse}");
            Console.WriteLine();

            Console.Write("Сколько книг вы прочитали за год? ");
            string booksText = Console.ReadLine() ?? "";
            bool wasSuccessful = int.TryParse(booksText, out int booksCount);
            Console.WriteLine($"wasSuccessful = {wasSuccessful}, booksCount = {booksCount}");
            Console.WriteLine();

            Console.Write("Имя и фамилия: ");
            string fullName = Console.ReadLine() ?? "";
            Console.Write("Название группы: ");
            string groupName = Console.ReadLine() ?? "";
            Console.Write("Год рождения: ");
            int birthYear = Convert.ToInt32(Console.ReadLine() ?? "");
            Console.Write("Средний балл за прошлый семестр: ");
            double averageMark = ReadDouble();
            Console.Write("Любимая буква алфавита: ");
            string letterText = Console.ReadLine() ?? "";
            char favoriteLetter = letterText[0];

            int ageIn2030 = 2030 - birthYear;
            bool isGoodStudent = averageMark >= 4.0;

            Console.WriteLine();
            Console.WriteLine($"Студент: {fullName}");
            Console.WriteLine($"Группа: {groupName}");
            Console.WriteLine($"Год рождения: {birthYear}");
            Console.WriteLine($"Средний балл: {averageMark:F1}");
            Console.WriteLine($"Любимая буква: {favoriteLetter} (код {(int)favoriteLetter})");
            Console.WriteLine($"В 2030 году исполнится: {ageIn2030} лет");
            Console.WriteLine($"Средний балл >= 4.0: {isGoodStudent}");
            Console.WriteLine();

            Console.Write("Рост в метрах: ");
            double height = ReadDouble();
            Console.Write("Вес в килограммах: ");
            double weight = ReadDouble();
            double bmi = weight / (height * height);
            Console.WriteLine($"ИМТ: {bmi:F2}");
            Console.WriteLine();
        }

        static double ReadDouble()
        {
            string text = Console.ReadLine() ?? "";
            return double.Parse(text.Replace('.', ','));
        }
    }
}
