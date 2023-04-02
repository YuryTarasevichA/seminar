 /* Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */
 /* bool result = IsThreeNumber (number);

Console.WriteLine();

bool IsThreeNumber (int num)
{
    return num / 10;
} */

 
Console.WriteLine("Введите число:");
int number =  Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
  number = number / 10;
  int newNumber = number;
  int threeNumber = newNumber % 10;
  Console.WriteLine($"Третья цифра числа {threeNumber}");
}
if (number <= 100)
{
    Console.WriteLine ("У заданного числа нет третьей цифры");
}

