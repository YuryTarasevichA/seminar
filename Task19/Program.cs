/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = ReverseNumber(num);
int ReverseNumber(int number)
{
    int reversed = 0;
    while (number > 0)
    {
        int digit = number % 10;
        reversed = reversed * 10 + digit;
        number /= 10;
    }
    return reversed;
}
if (result == num)
{
    Console.WriteLine("Это пятизначное число является палиндромом");
}
else
{
    Console.WriteLine("Это пятизначное число не является палиндромом");
}