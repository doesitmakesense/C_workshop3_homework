// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowOutput(int x)
{
    for (int i = 0; i < x; i++)
    {
        Console.Write(i * i * i + ", ");
    }
    Console.Write(x * x * x);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = Math.Abs(GetInput("Введите число N: "));

ShowOutput(x);