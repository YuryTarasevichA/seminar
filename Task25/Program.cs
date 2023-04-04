/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */
Console.WriteLine("Введите целое число А: ");
double numberA = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B: ");
double numberB = Convert.ToInt64(Console.ReadLine());
if (numberB > 0)
{
    double result = Degree(numberA, numberB);
    Console.WriteLine(($"Результат вычисления А в степени B: {result}"));
}
else Console.WriteLine($"Введено отрицательное число B!");
double Degree(double numA, double numB)
{
    double resultDegree = 1;
    for(double i = 1; i <= numB; i++)
    {
        checked
        {
            resultDegree *= numA;
        }
    }
    return resultDegree;
}
