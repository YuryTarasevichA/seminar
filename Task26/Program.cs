/* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3 */
Console.WriteLine("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = IndexNumber(number);
Console.Write($"->{result}");
int IndexNumber (int num)
{
    int count = 0;//вводим счётчик каунт
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;// возвращаем счётчик каунт
}