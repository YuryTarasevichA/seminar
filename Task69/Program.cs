/* Задача 69: Напишите программу, которая на вход принимает 
два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите целое положительное число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B");
int b = Convert.ToInt32(Console.ReadLine());
if (b >= 0)
{
    int result = DegreeNumber(a, b);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Некорректный ввод ");
int DegreeNumber (int aNumber, int bNumber)
{
    if (bNumber == 0) return 1;
    else return aNumber*DegreeNumber (aNumber, bNumber - 1);
}