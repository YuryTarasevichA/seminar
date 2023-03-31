// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 1 1
// 2 4
// 3 9
// 4 16
// 5 25 
// 6 36 

string Table(int Num)
{
    string tableResult = "______________________\n";//string.Empty
    for (int i = 0; i < Num; i++)
    {
        tableResult = tableResult + $"|{i, 4}     | {i*i, 4}    | \n";
    }
    tableResult = tableResult+ "-------------------------";
    return tableResult;

}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string result = Table(N);
Console.Write(result);

/* string Spreadsheet(int nNum)
{
    string spreadsheetResult = "________\n";
    for (int i = 1; i <= nNum; i++)
    {
        spreadsheetResult = spreadsheetResult + $"|{i}  | {i * i}| \n";
    }
    spreadsheetResult = spreadsheetResult+ "-----------";
    return spreadsheetResult;
}

Console.Write("Введи  число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result); */
