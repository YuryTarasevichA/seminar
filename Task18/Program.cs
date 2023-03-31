// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

/*  string Quoter(int quoterNumber) создаём метод (строчный, текстовый)
{
    if (quoterNumber==1) return " X>0, Y>0"; реализуем метод
    if (quoterNumber==2) return " X<0, Y>0";
    if (quoterNumber==3) return " X<0, Y<0";
    if (quoterNumber==4) return " X>0, Y<0";
    return "Неправильный номер четверти";
}

Console.Write("Введи  номер четверти "); строка ввода
int quorterNumberInput = Convert.ToInt32(Console.ReadLine()); строка ввода
String result = Quoter(quorterNumberInput); строка вывода
Console.Write(result); вывод в терминал*/ 

Console.Write("Введите номер четверти ");
int quoterNumberInput = Convert.ToInt32(Console.ReadLine());
string result = Quoter(quoterNumberInput);
Console.Write(result);

string Quoter (int quoterNumber)
{
    if(quoterNumber==1) return "x > 0, y > 0";
    if(quoterNumber==2) return "x < 0, y > 0";
    if(quoterNumber==3) return "x < 0, y < 0";
    if(quoterNumber==4) return "x > 0, y < 0";
    return "Неправильный номер четверти";
}
