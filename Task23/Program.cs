/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string result = Table(N);
string Table(int Num)
{
    string tableResult = "______________________\n";//string.Empty
    for (int i = 1; i <= Num; i++)
    {
        tableResult = tableResult + $"|{i, 4}     | {i*i*i, 4}    | \n";
    }
    tableResult = tableResult+ "-------------------------";
    return tableResult;

}

Console.Write(result);