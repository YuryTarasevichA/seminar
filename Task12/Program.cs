// напишите программу, которая будет принимать на вход два числа
// и выводить является ли первое число кратным второму.
// Если число один не кратно числу два, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int MultipleNumber (int firstNum, int secondNum)
{
    return firstNum % secondNum;
}
void WriteResult(int remainderInteger)
{
    if (remainderInteger == 0)
    {
        Console.WriteLine("кратно");
    }
    else 
    {
        Console.WriteLine($"не кратно, остаток {remainderInteger}");
    }
}
int result = MultipleNumber(firstNumber, secondNumber);
WriteResult(result);