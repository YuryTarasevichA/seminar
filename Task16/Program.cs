
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = IsFirstSecondSquare(firstNumber, secondNumber);

string res = result ? "Одно число является квадратом другого" : "Число не является квадратом другого";
Console.WriteLine(res);

bool IsFirstSecondSquare(int firstNum, int secondNum)
{
    return firstNumber == secondNum * secondNum || secondNum == firstNum * firstNum;
}