//Напишите программу, которая
//выводит трёхзначное число и удаляет вторую цифру из числа
//напиример: 456 ->46

int rundomNumber = new Random().Next(100, 1000);
int newNumber = DeleteSecondDigit(randomNumber);

Console.WriteLine($"Рандомное трёхзначное число: {rundomNumber}");
Console.WriteLine($"Получено двухзначное число: {newNumber}");

int DeleteSecondDigit(int rundomNum);
{
    int firstDigit = rundomNum / 100;
    int thirdDigit = rundomNum % 10;
    int newNumber = (firstDigit * 10) + thirdDigit;

    return newNumber;
}