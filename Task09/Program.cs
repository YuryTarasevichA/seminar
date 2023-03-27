// Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает наибольшую
//цифру числа, например:
// 78->8

// if (firstDigit > secondDigit) // ?
// {
//     Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// }
// else  // :
// {
//     Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
// }

//Math.Max(firstDigit, secondDigit);

//int maxDigit2 = MaxDigit(numberRandom2);
//Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int numberRandom = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число из отрезка 10 - 99 => {numberRandom}");
int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;

int numberRandom2 = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число из отрезка 10 - 99 => {numberRandom2}");
int firstDigit2 = numberRandom2 / 10;
int secondDigit2 = numberRandom2 % 10;

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit2 = MaxDigit(numberRandom2);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit (int numRandom) // numRandom = numberRandom
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}