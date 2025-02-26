using System;

public class Multiplier
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();
            int number1 = int.Parse(input1);

            Console.WriteLine("Введите второе число:");
            string input2 = Console.ReadLine();
            int number2 = int.Parse(input2);

            int result = number1 * number2;

            Console.WriteLine($"Результат умножения: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введены некорректные данные. Пожалуйста, введите целые числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}
