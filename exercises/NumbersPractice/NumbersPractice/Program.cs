int firstNumber = 10;
int secondNumber = 11;

int plus = firstNumber + secondNumber;
int minus = firstNumber - secondNumber;
int product = firstNumber * secondNumber;
int division = firstNumber / secondNumber;
double realDivision = (double)firstNumber / secondNumber;

Console.WriteLine($"{firstNumber} + {secondNumber} is {plus}");
Console.WriteLine($"{firstNumber} - {secondNumber} is {minus}");
Console.WriteLine($"{firstNumber} * {secondNumber} is {product}");
Console.WriteLine($"{firstNumber} / {secondNumber} is {division}");
Console.WriteLine($"{firstNumber} / {secondNumber} = {realDivision}");
Console.WriteLine($"{firstNumber} to the power of {secondNumber} is {Math.Pow(firstNumber, secondNumber)}");
Console.WriteLine($"square root of {firstNumber} is {Math.Sqrt(firstNumber)}");
Console.WriteLine($"{Math.Max(firstNumber, secondNumber)} is bigger than {Math.Min(firstNumber, secondNumber)}");
