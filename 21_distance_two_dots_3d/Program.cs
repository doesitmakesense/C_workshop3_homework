// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowQuarter(int ax, int ay, int az, int bx, int by, int bz)
{
    double distance = Math.Sqrt(Math.Pow(ax-bx, 2)+Math.Pow(ay-by, 2)+Math.Pow(az-bz, 2));
    Console.WriteLine($"{Math.Round(distance, 3)}"); //округление
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координатy x точки А: ");
int ay = GetInput("Введите координатy y точки А: ");
int az = GetInput("Введите координатy z точки А: ");
int bx = GetInput("Введите координатy x точки B: ");
int by = GetInput("Введите координатy y точки B: ");
int bz = GetInput("Введите координатy z точки B: ");


ShowQuarter(ax, ay, az, bx, by, bz);
