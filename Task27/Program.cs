/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.WriteLine("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = SumNumber(number);
Console.Write($"->{result}");
int SumNumber (int num)
{
    int count = 0; //вводим счётчик каунт
    int sum = 0; //ввели переменную для суммы
    int remainder = 0; //ввели переменную остатка
    while (num != 0)
    {
        remainder = num % 10;
        num = num / 10;
        sum = sum + remainder;
        count++; 
        
    }
    return sum;// возвращаем счётчик каунт
}
