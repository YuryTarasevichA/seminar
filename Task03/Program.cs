//Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите целое число от 1 до 7: ");
int numberday = Convert.ToInt32(Console.ReadLine());
if (numberday == 1)
{
    Console.WriteLine("это понедельник");
}
else if (numberday == 2)
{
    Console.WriteLine("это вторник");
}
else if (numberday == 3)
{
    Console.WriteLine("это среда");
}
else if (numberday == 4)
{
    Console.WriteLine("это четверг");
}
else if (numberday == 5)
{
    Console.WriteLine("это пятница");
}
else if (numberday == 6)
{
    Console.WriteLine("это суббота");
}
else if (numberday == 7)
{
    Console.WriteLine("это воскресенье");
}
else
{
    Console.WriteLine("это НЕ ДЕНЬ НЕДЕЛИ, ВВЕДИ ОТ 1 ДО 7!!!!!");
}