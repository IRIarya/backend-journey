Console.Write("enter a number : ");
int number = Convert.ToInt32(Console.ReadLine());
if  (number == 0)
{
    Console.WriteLine("your number is zero");
} else if  (number > 0)
{
    Console.WriteLine("your number is positive");
} else
{
    Console.WriteLine("your number is negative");
}