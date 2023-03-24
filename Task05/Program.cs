// Напишите программу, которая на вход принимает одно число, 
// а на выход показывает все целые числа в промежутке от N до N

Console.WriteLine ("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = - number;
while (count<=number)
{
    Console.WriteLine ($"{count}");
    count++;
}
Console.WriteLine();
