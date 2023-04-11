/* 42. Напишите программу, котрая
принимает на вход числои преобразовывает 
его в двоичный тип числа
 */

Console.WriteLine("Введите целое число:");
int number =  Convert.ToInt32(Console.ReadLine());

int MtdBinarySistem (int num)
{
    int resBinary = 0;
    int count = 1;
    while (num>0)
    {
        resBinary = resBinary+num % 2 * count;
        count*=10;
        num/=2;
        Console.WriteLine(resBinary);
    }
    return resBinary;
}
int binaryNumber = MtdBinarySistem(number);
Console.WriteLine($"Число {number} в двоичной системе {binaryNumber}");