// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void ShowOutput(int x)
{
    int firstDigit = x / 10000;
    int secondDigit = x / 1000 % 10;
    int fourthDigit = x / 10 % 10;
    int lastDigit = x % 10;

    if (firstDigit == lastDigit & secondDigit == fourthDigit) Console.WriteLine($"Число {x} - палиндром.");
    else if (x < 0) Console.WriteLine($"Число {x} - отрицательное, а отрицательные числа не могут быть палиндромами.");
    else if (x > 99999) Console.WriteLine($"Число {x} - не пятизначное, введите пятизначное число.");
    else if (x < 10000) Console.WriteLine($"Число {x} - не пятизначное, введите пятизначное число.");
    else Console.WriteLine($"Число {x} - не палиндром.");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите пятизначное число: ");

ShowOutput(x);