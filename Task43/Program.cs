/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine ("Введите параметры уровнения, коэффициент K1");
double k1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите параметры уровнения, коэффициент B1");
double b1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите параметры уровнения, коэффициент K2");
double k2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ("Введите параметры уровнения, коэффициент B2");
double b2 = Convert.ToInt64(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

if (y1 == y2)
{
    Console.WriteLine($"Координаты точки пересечения ({x}; {y1})");
}
else 
{
    Console.WriteLine($"Прямые не пересекаются");
} 


