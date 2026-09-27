Console.Write("what is your name ? ");
string name = Console.ReadLine() ?? "";
Console.WriteLine($"hello {name}");
Console.Write("enter your age ? ");
string age = Console.ReadLine() ?? "";
if  ( int.TryParse(age , out int intAge ) )
{
    Console.WriteLine($"you will be {intAge + 1} next year");
} else
{
    Console.WriteLine("your input was not a number");
}
Console.Write("enter your height : ");
string height = Console.ReadLine() ?? "";
if (double.TryParse(height, out double doubleHeight))
{
    Console.WriteLine($"your height is {doubleHeight}");
}
else
{
    Console.WriteLine("your input was not a number");
}
