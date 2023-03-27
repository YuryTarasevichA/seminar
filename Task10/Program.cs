//Напишите программу, которая принимает на 
//вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int randomNumber = new Random().Next(100, 1000);
int newNumber = SecondDigit(randomNumber);
Console.WriteLine($"Рандомное трёхзначное число: {randomNumber}");
Console.WriteLine($"Получена вторая цифра из числа: {newNumber}");

int SecondDigit (int randomNum)
{
    int twoDigit = randomNumber % 100;
    int firtTwoDigit = twoDigit /10;
    return firtTwoDigit;
}