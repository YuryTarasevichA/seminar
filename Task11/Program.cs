//Напишите программу, которая
//выводит трёхзначное число и удаляет вторую цифру из числа
//напиример: 456 ->46

int randomNumber = new Random().Next(100, 1000);
int newNumber = DeleteSecondDigit(randomNumber);

Console.WriteLine($"Рандомное трёхзначное число: {randomNumber}");
Console.WriteLine($"Получено двухзначное число: {newNumber}");

int DeleteSecondDigit(int randomNum)
{
    int firstDigit = randomNum / 100;
    int thirdDigit = randomNum % 10;
    int newNumber = (firstDigit * 10) + thirdDigit;

    return newNumber;
}