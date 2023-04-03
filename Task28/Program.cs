/* Напишите программу, которая
принимает на вход число N и выдаёт произведение
чисел от 1 до N.
4 -> 24
5->120
 */
Console.WriteLine("Введите целое положительное число: ");
double number = Convert.ToInt64(Console.ReadLine());
if (number > 0)
{
    double result = Factorial(number);
    Console.WriteLine(($"Результат вычисления факториала: {result}"));
}
else Console.WriteLine($"Введено отрицательное число!");
double Factorial(double num)
{
    double resultFactorial =1;
    for(double i = 1; i <= num; i++)
    {
        checked
        {
            resultFactorial *= i;
        }
    }
    return resultFactorial;
} 

