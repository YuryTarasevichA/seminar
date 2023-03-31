/* Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
 */

Console.WriteLine("Введите координаты точек ");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int X2= Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double result = Dictance(X1, Y1, X2, Y2);

double Dictance(int x1Coordinate, int y1Coordinate, int  x2Coordinate, int y2Coordinate)
{
    return Math.Sqrt((x1Coordinate-x2Coordinate)*(x1Coordinate-x2Coordinate)+(y1Coordinate-y2Coordinate)*(y1Coordinate-y2Coordinate)); 
}

Console.Write(Math.Round(result, 2, MidpointRounding.ToZero));

/* int Quarter (int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

double d = Math.Sqrt(5);
double num = 5.09987453;
double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
Console.WriteLine(numRound); */