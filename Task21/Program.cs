/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты точки A ");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
double result = Dictance(X1, Y1, Z1, X2, Y2, Z2);
double Dictance(int x1Coordinate, int y1Coordinate, int z1Coordinate, int  x2Coordinate, int y2Coordinate, int z2Coordinate)
{
    return Math.Sqrt((x1Coordinate-x2Coordinate)*(x1Coordinate-x2Coordinate)+(y1Coordinate-y2Coordinate)*(y1Coordinate-y2Coordinate)+
    (z1Coordinate-z2Coordinate)*(z1Coordinate-z2Coordinate));
}
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));


