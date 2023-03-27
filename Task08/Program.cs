/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все чётные числа от 1 до {0}:", number);

for (int index = 2; index <= number; index +=2)
{
    Console.WriteLine(index);
}