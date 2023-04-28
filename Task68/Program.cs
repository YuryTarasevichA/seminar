/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());
int ackermanF = AckermanFunction(m, n);
if (m > 0 && n > 0)
    Console.WriteLine(ackermanF);
else
    Console.WriteLine("Некорректный ввод!");

int AckermanFunction (int numM, int numN)
{
    if (numM == 0)
    return numN + 1;
    else if (numN == 0)
    return AckermanFunction (numM - 1, 1);
    else return AckermanFunction(numM - 1, AckermanFunction(numM, numN-1));
}
/* if ((numM == 1) && (numN == 1))
        return 1;
    else if (numM > 1)
        return AckermanFunction(numM - 1, numN) + numN;
    else
        return AckermanFunction(numM, numN - 1) + 1; */