/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число для деления:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число для деления:");
int secondNumber = int.Parse(Console.ReadLine());

bool result = IsMultipleTwoNumber (number, firstNumber, secondNumber);

Console.WriteLine(result? $"Число {number} кратно данным числам" : $"Число {number} не кратно данным числам");

bool IsMultipleTwoNumber (int num, int firstNum, int secondNum)
{
    return num % firstNum == 0 && num % secondNum == 0;
}
