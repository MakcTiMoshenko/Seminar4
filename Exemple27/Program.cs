// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
    }

int Count(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number%10;
        number = number / 10;
    }
    return result;
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел числа {number} = {Count(number)}");
