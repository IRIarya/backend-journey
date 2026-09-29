Console.WriteLine("=== CALCULATOR ===");

Console.Write("Enter first number: ");
string firstInput = Console.ReadLine() ?? "";

Console.Write("Enter second number: ");
string secondInput = Console.ReadLine() ?? "";

Console.Write("Choose operation (+, -, *, /): ");
string operation = (Console.ReadLine() ?? "").ToLower();

if (!double.TryParse(firstInput, out double firstNumber))
{
    Console.WriteLine("First number is invalid.");
}
else if (!double.TryParse(secondInput, out double secondNumber))
{
    Console.WriteLine("Second number is invalid.");
}
else if (operation == "+" || operation == "plus" || operation == "add" || operation == "addition")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
}
else if (operation == "-" || operation == "minus" || operation == "subtract" || operation == "subtraction")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if (operation == "*" || operation == "multiply" || operation == "product")
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
}
else if (operation == "/" || operation == "divide" || operation == "division")
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Denominator cannot be 0.");
    }
    else
    {
        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
    }
}
else
{
    Console.WriteLine($"Unknown operation: {operation}");
}